using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MudTestApp.Models
{
    public class User : IdentityUser
    {
        //inherits all identityUser properties
        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }

}
