using System.ComponentModel.DataAnnotations;

namespace HuyWebStore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}