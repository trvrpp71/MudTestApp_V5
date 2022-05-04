using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MudTestApp.Models
{
    public class Test
    {
        public int TestID { get; set; }

        [Required]
        public string? Customer { get; set; }

        [Display(Name ="Customer Contact")]
        public string? CustomerContact { get; set; }
        
        [Display(Name = "Lab Tech")]
        public string? LabTechAssigned { get; set; }

        [Required]
        [Display(Name ="Mud Type")]
        public string? MudType { get; set; }

        [Display(Name ="Mud System")]
        public string? MudSystemName { get; set; }

        [Required (ErrorMessage = "The date the sample is received in the lab is required.")]
        [DataType(DataType.Date), Display(Name ="Sample Rec'd On"), DisplayFormat(DataFormatString ="{0:dd-MMM-yy}")]
        public DateTime ReceivedDate { get; set; }

        [Required (ErrorMessage = "Exposure time is required. Please enter the number of hours being exposed.")]
        [Display(Name ="Exposure Time (hrs)")]
        public string? ExposureTime { get; set; }

        [DataType(DataType.Date), Display(Name = "Started Immersion on"), DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime? DateStarted { get; set; }

        [DataType(DataType.Date), Display(Name = "Removed from Fluid on"), DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime? DateEnded { get; set; }

        [DataType(DataType.Date), Display(Name = "Time of Removal"), DisplayFormat(DataFormatString = "{0:00}")]
        public DateTime? TimeOut { get; set; }

        [Display(Name = "Comments")]
        public string? TestComments { get; set; }


        public ICollection<TestResults>?Results { get; set; }

        //Test is a 1-to-many relationships with TestResults

        

    }
}
