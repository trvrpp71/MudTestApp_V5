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

        [Display(Name = "Hardness After")]
        [Required]
        public double S1Hardness_a { get; set; }

        [Display(Name = "Hardness Before")]
        [Required]
        public double S1Hardness_b { get; set; }

        [Display(Name = "Weight in air AFTER")]
        [Required]
        public double S1WtAir_a { get; set; }

        [Display(Name = "Weight in air BEFORE")]
        [Required]
        public double S1WtAir_b { get; set; }

        [Display(Name = "Weight in water AFTER")]
        [Required]
        public double S1WtWater_a { get; set; }

        [Display(Name = "Weight in water BEFORE")]
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
        [Required]
        public double S2Thickness { get; set; }

        [Display(Name = "Hardness After")]
        [Required]
        public double S2Hardness_a { get; set; }

        [Display(Name = "Hardness Before")]
        [Required]
        public double S2Hardness_b { get; set; }

        [Display(Name = "Weight in air AFTER")]
        [Required]
        public double S2WtAir_a { get; set; }

        [Display(Name = "Weight in air BEFORE")]
        [Required]
        public double S2WtAir_b { get; set; }

        [Display(Name = "Weight in water AFTER")]
        [Required]
        public double S2WtWater_a { get; set; }

        [Display(Name = "Weight in water BEFORE")]
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
        [Required]
        public double S3Thickness { get; set; }

        [Display(Name = "Hardness After")]
        [Required]
        public double S3Hardness_a { get; set; }

        [Display(Name = "Hardness Before")]
        [Required]
        public double S3Hardness_b { get; set; }

        [Display(Name = "Weight in air AFTER")]
        [Required]
        public double S3WtAir_a { get; set; }

        [Display(Name = "Weight in air BEFORE")]
        [Required]
        public double S3WtAir_b { get; set; }

        [Display(Name = "Weight in water AFTER")]
        [Required]
        public double S3WtWater_a { get; set; }

        [Display(Name = "Weight in water BEFORE")]
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

        //general observations
        public string? Observations { get; set; }


        //calcualted column
        //public double Hardness_Before_Avg { get; private set; }  //Round(([ShoreAB_1]+[ShoreAB_2]+[ShoreAB_3])/3,1) AS [AVG ShoreA(B)]
        //public double Hardness_After_Avg { get; private set; }  //Round(([ShoreAA_1]+[ShoreAA_2]+[ShoreAA_3])/3,1) AS [AVG ShoreA(A)]
        //public double HardnessChange { get; private set; } //AVG ShoreA(A)]-[AVG ShoreA(B)] AS [AVG Hard Chg]

        //public double AirWt_Before_Avg { get; set; } //Round(([Wt_AirB_1]+[Wt_AirB_2]+[Wt_AirB_3])/3,0) AS [AVG Wt in air (B)]
        //public double AirWt_After_Avg { get; set; } //Round(([Wt_AirA_1]+[Wt_AirA_2]+[Wt_AirA_3])/3,0) AS [AVG Wt in air (A)]

        //public double WaterWt_Before_Avg { get; set; } //Round(([Wt_WaterB_1]+[Wt_WaterB_2]+[Wt_WaterB_3])/3,0) AS [AVG Wt in water (B)]
        //public double WaterWt_After_Avg { get; set; } //Round(([Wt_WaterA_1]+[Wt_WaterA_2]+[Wt_WaterA_3])/3,0) AS [AVG Wt in water (A)]


        //public double S1_Wt_Change { get; set; } //Round(([Wt_AirA_1]-[Wt_AirB_1])/[Wt_AirB_1]*100,3) AS wtChange_1
        //public double S2_Wt_Change { get; set; }   // Round(([Wt_AirA_2]-[Wt_AirB_2])/[Wt_AirB_2]*100,3) AS wtChange_2
        //public double S3_Wt_Change { get; set; } // Round(([Wt_AirA_3]-[Wt_AirB_3])/[Wt_AirB_3]*100,3) AS wtChange_3
        //public double Avg_Wt_Change { get; set; }   //Round(([wtChange_1]+[wtChange_2]+[wtChange_3])/3,2) AS [AVG wtChange]


        //public double S1_Vol_Change { get; set; }//Round((([Wt_AirA_1]-[Wt_WaterA_1])-([Wt_AirB_1]-[Wt_WaterB_1]))/([Wt_AirB_1]-[Wt_WaterB_1])*100,3) AS VolChange_1
        //public double S2_Vol_Change { get; set; }//Round((([Wt_AirA_2]-[Wt_WaterA_2])-([Wt_AirB_2]-[Wt_WaterB_2]))/([Wt_AirB_2]-[Wt_WaterB_2])*100,3) AS VolChange_2
        //public double S3_Vol_Change { get; set; }//Round((([Wt_AirA_3]-[Wt_WaterA_3])-([Wt_AirB_3]-[Wt_WaterB_3]))/([Wt_AirB_3]-[Wt_WaterB_3])*100,3) AS VolChange_3
        //public double Avg_Vol_Change { get; set; }//Round(([VolChange_1]+[VolChange_2]+[VolChange_3])/3,2) AS[AVG VolChange]

        //public int Avg_25Mod {get; set;} //Round(([25_Mod_1]+[25_Mod_2]+[25_Mod_3])/3,2) AS[AVG 25mod]

        //public int Avg_50Mod { get; set; } // Round(([50_Mod_1]+[50_Mod_2]+[50_Mod_3])/3,2) AS[AVG 50mod]
        //public int Avg_100Mod { get; set; } // Round(([100_Mod_1]+[100_Mod_2]+[100_Mod_3])/3,2) AS[AVG 100mod]
        //public int Avg_Tensile { get; set; } // Round(([Tensile_1]+[Tensile_2]+[Tensile_3])/3,0) AS[AVG Tensile]
        //public int Avg_ELongation { get; set; }// Round(([Elongation_1]+[Elongation_2]+[Elongation_3])/3,0) AS[AVG Elongation]


        public Test Test { get; set; } //nav prop
        public Compound Compound { get; set; }  //nav prop

    }
}
