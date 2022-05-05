
using System.Collections.Generic;

namespace MudTestApp.Models.TestViewModels
{
    public class TestIndexData
    {
        public Test Test { get; set; }
        public Compound? Compound { get; set; }
        public IEnumerable<TestResults>? TestResults { get; set; }
    }
}
