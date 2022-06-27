using System.ComponentModel.DataAnnotations;

namespace MudTestApp.Models.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set;}
    }
}
