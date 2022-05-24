
using System.Collections.Generic;


namespace MudTestApp.Models.TestViewModels
{
    public class TestDetailViewModel
    {

        public Test TestDVm { get; set; }    //1 test

        public Customer CustomerDVm { get; set; } // 1 customer

        public IEnumerable<Compound>? CompoundsDVm { get; set; } //multiple compounds

        public IEnumerable<TestResults>? TestResultsDVm { get; set; } //multiple tests
    }
}
