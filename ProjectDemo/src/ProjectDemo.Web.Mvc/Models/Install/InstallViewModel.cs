using System.Collections.Generic;
using Abp.Localization;
using ProjectDemo.Install.Dto;

namespace ProjectDemo.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
