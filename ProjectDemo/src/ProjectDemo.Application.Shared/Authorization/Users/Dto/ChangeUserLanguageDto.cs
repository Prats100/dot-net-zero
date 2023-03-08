using System.ComponentModel.DataAnnotations;

namespace ProjectDemo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
