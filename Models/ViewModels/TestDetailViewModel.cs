
using System.Collections.Generic;


namespace MudTestApp.Models.TestViewModels
{
    public class TestDetailViewModel
    {

        public Test Test { get; set; }    //1 test

        public Customer Customer { get; set; } // 1 customer

        public IEnumerable<Compound>? Compounds { get; set; } //multiple compounds

        public IEnumerable<TestResults>? TestResults { get; set; } //multiple tests
    }
}
