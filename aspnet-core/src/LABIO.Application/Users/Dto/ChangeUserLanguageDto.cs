using System.ComponentModel.DataAnnotations;

namespace LABIO.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}