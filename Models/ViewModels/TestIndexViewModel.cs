
using System.Collections.Generic;


namespace MudTestApp.Models.TestViewModels
{
    public class TestIndexViewModel
    {

        public Test TestVm { get; set; }    //1 test
        public Customer CustomerVm { get; set; } // 1 customer

        //public IEnumerable<TestResults>? TestResults { get; set; } //multiple testss
    }
}
