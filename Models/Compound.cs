using System.Collections.Generic;

namespace MudTestApp.Models
{
    public class Compound
    {
        public int CompoundID { get; set; } //primaryKey
        public string CompoundName { get; set; }
        public int C_Hardness { get; set; }
        public int C_25Mod { get; set; }
        public int C_50Mod { get; set; }
        public int C_100Mod { get; set; }
        public int C_Tensile { get; set; }
        public int C_Elongation { get; set; }
        public bool C_Production { get; set; }

        public ICollection<TestData> Datas { get; set; }
            
        //a single compound beings tested at mutliple temps
        //multiple compounds per test

    }
}
