using System.ComponentModel.DataAnnotations;

namespace Viewtance.ERP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}