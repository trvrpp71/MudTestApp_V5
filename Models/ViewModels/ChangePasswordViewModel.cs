using System.ComponentModel.DataAnnotations;

namespace MudTestApp.Models.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }  
        public string UserName { get; set; }    

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }
        

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("NewPassword", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
