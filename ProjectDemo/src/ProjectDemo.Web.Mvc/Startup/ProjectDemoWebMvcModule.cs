using Abp.AspNetZeroCore;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Hangfire.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;
using Hangfire;
using Hangfire.Common;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using ProjectDemo.Auditing;
using ProjectDemo.Configuration;
using ProjectDemo.EntityFrameworkCore;
using ProjectDemo.MultiTenancy;
using ProjectDemo.Web.Areas.App.Startup;
using System;

namespace ProjectDemo.Web.Startup
{
    [DependsOn(
        typeof(ProjectDemoWebCoreModule)
    )]
    public class ProjectDemoWebMvcModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ProjectDemoWebMvcModule(IWebHostEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpWebCommon().MultiTenancy.DomainFormat = _appConfiguration["App:WebSiteRootAddress"] ?? "https://localhost:44302/";
            Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];
            Configuration.Navigation.Providers.Add<AppNavigationProvider>();

            //Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            

            Configuration.BackgroundJobs.UserTokenExpirationPeriod = TimeSpan.FromHours(1);

            IocManager.Register<DashboardViewConfiguration>();
            Configuration.BackgroundJobs.UseHangfire();
            
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectDemoWebMvcModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!IocManager.Resolve<IMultiTenancyConfig>().IsEnabled)
            {
                return;
            }

            using (var scope = IocManager.CreateScope())
            {
                if (!scope.Resolve<DatabaseCheckHelper>().Exist(_appConfiguration["ConnectionStrings:Default"]))
                {
                    return;
                }
            }
          

            var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
            workManager.Add(IocManager.Resolve<SubscriptionExpirationCheckWorker>());
            workManager.Add(IocManager.Resolve<SubscriptionExpireEmailNotifierWorker>());
            //workManager.Add((IBackgroundWorker)IocManager.Resolve<MakeInactiveUsersPassiveWorker>());
          
            ///RecurringJob.AddOrUpdate("easyjob", () => Console.Write("Easy!"), Cron.Minutely());
            RecurringJob.AddOrUpdate<IMakeInactiveUsersPassiveWorker>("Sending Email", x => x.DoWork1(), "30 20 * * *", timeZone: TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time"));
        

  

            if (Configuration.Auditing.IsEnabled && ExpiredAuditLogDeleterWorker.IsEnabled)
            {
                workManager.Add(IocManager.Resolve<ExpiredAuditLogDeleterWorker>());
            }






        }
    }
}