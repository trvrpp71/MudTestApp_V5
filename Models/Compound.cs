#nullable disable

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MudTestApp.Models
{
    public class Compound
    {
        public int CompoundID { get; set; } //primaryKey

        [Required]
        public string CompoundName { get; set; }
        [Required]
        public int C_Hardness { get; set; }
        [Required]
        public int C_25Mod { get; set; }
        [Required]
        public int C_50Mod { get; set; }
        [Required]
        public int C_100Mod { get; set; }
        [Required]
        public int C_Tensile { get; set; }
        [Required]
        public int C_Elongation { get; set; }
        [Required]
        public bool C_Production { get; set; }

        public ICollection<TestResults> Results { get; set; }

        //one-to-many with TestResults

    }
}
