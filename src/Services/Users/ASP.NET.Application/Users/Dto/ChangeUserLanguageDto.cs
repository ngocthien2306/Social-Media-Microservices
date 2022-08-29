using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}