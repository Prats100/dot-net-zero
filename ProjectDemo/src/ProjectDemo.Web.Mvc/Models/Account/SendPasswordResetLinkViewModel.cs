using System.ComponentModel.DataAnnotations;

namespace ProjectDemo.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}