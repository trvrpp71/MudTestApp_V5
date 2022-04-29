using System;
using System.Collections.Generic;

namespace MudTestApp.Models
{
    public class Test
    {
        public int Id { get; set; }

        public string Customer { get; set; }

        public string CustomerContact { get; set; }

        public string LabTechAssigned { get; set; }

        public string MudType { get; set; }
        public string MudSystemName { get; set; }

        public DateTime ReceivedDate { get; set; }

        public string ExposureTime { get; set; }
        public DateTime DateStarted { get; set; }

        public DateTime DateEnded { get; set; }

        public DateTime TimeOut { get; set; }

        public string TestComments { get; set; }

        
        public ICollection<Compound> Compounds { get; set; }

        //Test is a 1-to-many relationships with Compounds
        //as you will have 1 test with multiple compounds being tested 
        

    }
}
