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


        //sample 2 variables
        public double S2Thickness { get; set; }
        [Required]
        public double S2Hardness_a { get; set; }
        [Required]
        public double S2Hardness_b { get; set; }
        [Required]
        public double S2WtAir_a { get; set; }
        [Required]
        public double S2WtAir_b { get; set; }
        [Required]
        public double S2WtWater_a { get; set; }
        [Required]
        public double S2WtWater_b { get; set; }
        [Required]
        public int S2_25Mod { get; set; }
        [Required]
        public int S2_50Mod { get; set; }
        [Required]
        public int S2_100Mod { get; set; }
        [Required]
        public int S2_tensile { get; set; }
        [Required]
        public int S2_elongation { get; set; }

        //Sample3 variables
        public double S3Thickness { get; set; }
        [Required]
        public double S3Hardness_a { get; set; }
        [Required]
        public double S3Hardness_b { get; set; }
        [Required]
        public double S3WtAir_a { get; set; }
        [Required]
        public double S3WtAir_b { get; set; }
        [Required]
        public double S3WtWater_a { get; set; }
        [Required]
        public double S3WtWater_b { get; set; }
        [Required]
        public int S3_25Mod { get; set; }
        [Required]
        public int S3_50Mod { get; set; }
        [Required]
        public int S3_100Mod { get; set; }
        [Required]
        public int S3_tensile { get; set; }
        [Required]
        public int S3_elongation { get; set; }

        public Test Test { get; set; } //nav prop
        public Compound Compound { get; set; }  //nav prop

    }
}
