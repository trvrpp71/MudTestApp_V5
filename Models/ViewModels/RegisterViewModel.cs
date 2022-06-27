using System.ComponentModel.DataAnnotations;

namespace MudTestApp.Models.ViewModels
{
    public class RegisterViewModel
    {

        [Required]
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare("Password", ErrorMessage ="Passwords do not match.")]
        public string ConfirmPassword { get; set;}

    }
}
