using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MudTestApp.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string CompanyName { get; set; } 
        public string? ContactName { get; set; }

        public ICollection<Test> Tests { get; set; }

        //1 customer to many tests

    }
}
