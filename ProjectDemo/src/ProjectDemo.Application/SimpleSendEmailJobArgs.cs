using Abp.BackgroundJobs;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Net.Mail;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using Abp.Timing;
using Microsoft.Extensions.Logging;
using ProjectDemo.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo
{

    [Serializable]
    public class SimpleSendEmailJobArgs
    {
        public long SenderUserId { get; set; }

        public long TargetUserId { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }

    public class SimpleSendEmailJob : AsyncBackgroundJob<SimpleSendEmailJobArgs>,ITransientDependency
    {

        private readonly IRepository<User,long> _userRepository;
        private readonly IEmailSender _emailSender;

        public SimpleSendEmailJob(IRepository<User,long> userRepository,IEmailSender emailSender)
        {
            _userRepository = userRepository;   
            _emailSender = emailSender;
            
        }

        [UnitOfWork]
        public override async Task ExecuteAsync(SimpleSendEmailJobArgs args)
        {
            var senderUser=_userRepository.Get(args.SenderUserId);  
            var targetUser=_userRepository.Get(args.TargetUserId);  

            await _emailSender.SendAsync(senderUser.EmailAddress,targetUser.EmailAddress,args.Subject,args.Body);  
            
        }
    }
    public class SendEmailInput
    {
        public long SenderUserId { get; set; }

        public long TargetUserId { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }
    public class MakeInactiveUsersPassiveWorker : PeriodicBackgroundWorkerBase,IMakeInactiveUsersPassiveWorker, ISingletonDependency
    {
        private readonly IRepository<User, long> _userRepository;

        public MakeInactiveUsersPassiveWorker(AbpTimer timer, IRepository<User, long> userRepository)
            : base(timer)
        {
            _userRepository = userRepository;
            Timer.Period = 5000; 
        }


        [UnitOfWork]
        public  void DoWork1()
        { 
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                Logger.Info("Starting: Setting status of inactive users...");

                var oneMonthAgo = Clock.Now.Subtract(TimeSpan.FromDays(30));

                var inactiveUsers =  _userRepository.GetAllList();
                foreach (var inactiveUser in inactiveUsers)
                {
                    inactiveUser.IsActive = false;
                    Logger.Info(inactiveUser.Id + " made passive since he/she did not login in last 30 days.");
                   
                   
                }

                CurrentUnitOfWork.SaveChanges();
            }
        }

        protected override void DoWork()
        {
            Console.WriteLine("succesfully done");
            
        }
    }


}
