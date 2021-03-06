#nullable disable

using System.ComponentModel.DataAnnotations;

namespace MudTestApp.Models
{
    public class TestResults
    {
        public int TestResultsID { get; set; }  //primary key

        [Display(Name ="Test #")]
        public int TestID { get; set; } //foreign key 

        [Display(Name ="Compound Tested")]
        public int CompoundID { get; set; } //foreign key

        [Display(Name = "Test Temperature")]
        [Required]
        public int TestTemp { get; set; }

         [Display(Name = "S1 Thk")]
        public double S1Thickness { get; set; }

        [Display(Name = "Hardness After")]
        public double S1Hardness_a { get; set; }

        [Display(Name = "Hardness Before")]
 
        public double S1Hardness_b { get; set; }

        [Display(Name = "Weight in air AFTER")]
 
        public double S1WtAir_a { get; set; }

        [Display(Name = "Weight in air BEFORE")]
 
        public double S1WtAir_b { get; set; }

        [Display(Name = "Weight in water AFTER")]
 
        public double S1WtWater_a { get; set; }

        [Display(Name = "Weight in water BEFORE")]
 
        public double S1WtWater_b { get; set; }

        [Display(Name = "S1 25% Modulus")]

        public double S1_25Mod { get; set; }

        [Display(Name = "S1 50% Modulus")]

        public double S1_50Mod { get; set; }

        [Display(Name = "S1 100% Modulus")]

        public double S1_100Mod { get; set; }

        [Display(Name = "S1 Tensile")]

        public double S1_tensile { get; set; }

        [Display(Name = "S1 Elong")]

        public double S1_elongation { get; set; }


        //sample 2 variables
        [Display(Name = "S2 Thk")]
  
        public double S2Thickness { get; set; }

        [Display(Name = "Hardness After")]

        public double S2Hardness_a { get; set; }

        [Display(Name = "Hardness Before")]

        public double S2Hardness_b { get; set; }

        [Display(Name = "Weight in air AFTER")]

        public double S2WtAir_a { get; set; }

        [Display(Name = "Weight in air BEFORE")]

        public double S2WtAir_b { get; set; }

        [Display(Name = "Weight in water AFTER")]

        public double S2WtWater_a { get; set; }

        [Display(Name = "Weight in water BEFORE")]

        public double S2WtWater_b { get; set; }

        [Display(Name = "S2 25% Modulus")]

        public double S2_25Mod { get; set; }

        [Display(Name = "S2 50% Modulus")]

        public double S2_50Mod { get; set; }

        [Display(Name = "S2 100% Modulus")]

        public double S2_100Mod { get; set; }

        [Display(Name ="S2 Tensile")]

        public double S2_tensile { get; set; }

        [Display(Name = "S2 Elong")]

        public double S2_elongation { get; set; }

        //Sample3 variables
        [Display(Name = "S3 Thk")]

        public double S3Thickness { get; set; }

        [Display(Name = "Hardness After")]

        public double S3Hardness_a { get; set; }

        [Display(Name = "Hardness Before")]

        public double S3Hardness_b { get; set; }

        [Display(Name = "Weight in air AFTER")]

        public double S3WtAir_a { get; set; }

        [Display(Name = "Weight in air BEFORE")]

        public double S3WtAir_b { get; set; }

        [Display(Name = "Weight in water AFTER")]
 
        public double S3WtWater_a { get; set; }

        [Display(Name = "Weight in water BEFORE")]
 
        public double S3WtWater_b { get; set; }

        [Display(Name = "S3 25% Modulus")]
 
        public double S3_25Mod { get; set; }

        [Display(Name = "S3 50% Modulus")]
 
        public double S3_50Mod { get; set; }

        [Display(Name = "S3 100% Modulus")]
 
        public double S3_100Mod { get; set; }

        [Display(Name = "S3 Tensile")]
 
        public double S3_tensile { get; set; }

        [Display(Name = "S3 Elong")]
 
        public double S3_elongation { get; set; }


        //general observations
        public string? Observations { get; set; }


        public Test Test { get; set; } //nav prop
        public Compound Compound { get; set; }  //nav prop

    }
}
