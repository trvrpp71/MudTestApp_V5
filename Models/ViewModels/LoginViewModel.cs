using System.ComponentModel.DataAnnotations;

namespace MudTestApp.Models.TestViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]   
        [StringLength(255)]
        public string Password { get; set; }

        public string? ReturnUrl { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }

    }
}
