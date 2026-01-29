using System.ComponentModel.DataAnnotations;

namespace WebATB.Models.Users;

public class UserCreateModel
{
    [Display(Name = "Прізвище")]
    [Required(ErrorMessage = "Вкажіть прізвище")]
    public string LastName { get; set; } = string.Empty;

    [Display(Name = "Ім'я")]
    [Required(ErrorMessage = "Вкажіть ім'я")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Виберіть фото будь ласка")]
    public IFormFile UserPhoto { get; set; }
}
