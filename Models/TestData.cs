namespace MudTestApp.Models
{
    public class TestData
    {
        public int DataID { get; set; } //primary key
        public int CompoundID { get; set; } //foreign key



        public int TestTemp { get; set; }
        public double S1Thickness { get; set; }
        public double S1Hardness_a { get; set; }
        public double S1Hardness_b { get; set; }

        public double S1WtAir_a { get; set; }
        public double S1WtAir_b { get; set; }
        public double S1WtWater_a { get; set; }
        public double S1WtWater_b { get; set; }

        public int S1_25Mod { get; set; }
        public int S1_50Mod { get; set; }
        public int S1_100Mod { get; set; }
        public int S1_tensile { get; set; }
        public int S1_elongation { get; set; }

        //navigation properties
        public Compound Compound { get; set; }  
        
        //a test can only be associated with one compound


        


    }
}
