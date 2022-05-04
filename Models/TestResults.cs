#nullable disable

using System.ComponentModel.DataAnnotations;

namespace MudTestApp.Models
{
    public class TestResults
    {
        public int TestResultsID { get; set; }  //primary key
        public int TestID { get; set; } //foreign key 
        public int CompoundID { get; set; } //foreign key

        [Required]
        public int TestTemp { get; set; }
        [Required]
        public double S1Thickness { get; set; }
        [Required]
        public double S1Hardness_a { get; set; }
        [Required]
        public double S1Hardness_b { get; set; }
        [Required]
        public double S1WtAir_a { get; set; }
        [Required]
        public double S1WtAir_b { get; set; }
        [Required]
        public double S1WtWater_a { get; set; }
        [Required]
        public double S1WtWater_b { get; set; }
        [Required]
        public int S1_25Mod { get; set; }
        [Required]
        public int S1_50Mod { get; set; }
        [Required]
        public int S1_100Mod { get; set; }
        [Required]
        public int S1_tensile { get; set; }
        [Required]
        public int S1_elongation { get; set; }

        public Test Test { get; set; } //nav prop
        public Compound Compound { get; set; }  //nav prop

    }
}
