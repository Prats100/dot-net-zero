using Abp.Localization;

namespace ProjectDemo.Web.Areas.App.Models
{
    public class PhoneRowInPersonListViewModel
    {
        public PhoneInPersonListDto Phone { get; set; }

        public PhoneRowInPersonListViewModel(PhoneInPersonListDto phone)
        {
            Phone = phone;
        }

        public string GetPhoneTypeAsString()
        {
            return LocalizationHelper.GetString(ProjectDemoConsts.LocalizationSourceName, "PhoneType_" + Phone.Type);
        }
    }
}
