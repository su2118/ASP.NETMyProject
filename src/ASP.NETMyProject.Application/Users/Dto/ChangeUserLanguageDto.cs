using System.ComponentModel.DataAnnotations;

namespace ASP.NETMyProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}