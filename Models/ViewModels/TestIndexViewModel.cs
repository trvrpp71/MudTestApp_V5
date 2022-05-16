
using System.Collections.Generic;


namespace MudTestApp.Models.TestViewModels
{
    public class TestIndexViewModel
    {

        public Test TestVm { get; set; }    //1 test
        public Customer CustomerVm { get; set; } // 1 customer

        public IEnumerable<Compound>? CompoundVm { get; set; } //multiple compounds
        public IEnumerable<TestResults>? TestResultsVm { get; set; } //multiple testss

    }
}
