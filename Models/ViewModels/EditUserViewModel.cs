using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MudTestApp.Models.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Roles = new List<string>();

        }
        public string Id { get; set; }  

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public IList<string> Roles { get; set; }
    }
}
