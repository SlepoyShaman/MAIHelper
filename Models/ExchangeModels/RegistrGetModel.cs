using System.ComponentModel.DataAnnotations;

namespace maihelper.Models.ExchangeModels
{
    public class RegistrGetModel
    {
        [Required(ErrorMessage = "Вы не ввели Email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Вы не ввели логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Вы не ввели пароль")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Пароль не может быть меньше 6 символов или больше 30")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Повторите пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают!")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
        
    }
}
