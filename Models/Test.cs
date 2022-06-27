using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MudTestApp.Models
{
    /* 
     * 1 customer can have many tests 
     * 1 test per customer
     * 1 test can have mutliple compounds
     * 1 test can have mutliple results
     
     */
    public class Test
    {
        
        public int TestID { get; set; }

        public int CustomerID { get; set; }  //foreign key

        [Display(Name ="RMA")]
        public int? Epicor { get; set; }

        [Display(Name = "Contact")]
        public string? ContactName { get; set; }    

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

        //[DataType(DataType.Date), Display(Name = "Removed from Fluid on"), DisplayFormat(DataFormatString = "{0:dd-MMM-yy HH:mm}",ApplyFormatInEditMode =true),]
        [DataType(DataType.DateTime), Display(Name = "Removed from Fluid on")]
        public DateTime? DateEnded { get; set; }

        //[DataType(DataType.Date), Display(Name = "Time of Removal"), DisplayFormat(DataFormatString = "{HH:mm}")]
        //public DateTime? TimeOut { get; set; }

        [Display(Name = "Comments")]
        public string? TestComments { get; set; }

        public Customer? Customer { get; set; }

        public ICollection<TestResults>?Results { get; set; }

        //Each test can only be associated to one customer
        //Test is a 1-to-many relationships with TestResults

        

    }
}
