using MudTestApp.Models;
using System;
using System.Linq;

namespace MudTestApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(MudTestContext context)
        {
            context.Database.EnsureCreated();

            //look for existing data
            if (context.Compounds.Any())
            {
                return; //db has been seeded
            }

            //seed Compound Table
            var compounds = new Compound[]
            {
                new Compound
                {
                    CompoundName = "TR", C_Hardness = 78, C_100Mod = 607, C_50Mod = 336, C_25Mod = 221,
                    C_Elongation = 372, C_Tensile = 2646, C_Production = true
                },
                new Compound
                {
                    CompoundName = "HS88", C_Hardness = 90, C_100Mod = 939, C_50Mod = 734, C_25Mod = 653,
                    C_Elongation = 316, C_Tensile = 1605, C_Production = true
                },
                new Compound
                {
                    CompoundName = "HT89", C_Hardness = 90, C_100Mod = 1156, C_50Mod = 756, C_25Mod = 560,
                    C_Elongation = 322, C_Tensile = 1400, C_Production = true
                },
                new Compound
                {
                    CompoundName = "MI2011", C_Hardness = 87, C_100Mod = 1326, C_50Mod = 881, C_25Mod = 678,
                    C_Elongation = 273, C_Tensile = 2637, C_Production = false
                }
            };
            foreach (Compound c in compounds)
            {
                context.Compounds.Add(c);
            }
            context.SaveChanges();

            //Seed Test Table
            var tests = new Test[]
            {
                new Test
                {
                    Customer = "Weatherford", CustomerContact = "Joe", LabTechAssigned = "Patrick",
                    MudType = "OBM", MudSystemName = "WARP", ReceivedDate = DateTime.Parse("2014-03-10"),
                    DateStarted = DateTime.Parse("2014-03-11"), DateEnded = DateTime.Parse("2014-03-19"),
                    TimeOut = DateTime.Parse("14:52:00"), ExposureTime = "192 hours"
                },
                new Test
                {
                    Customer = "Pro Directional", CustomerContact = "Marty", LabTechAssigned = "Brandon",
                    MudType = "WBM", ReceivedDate = DateTime.Parse("2014-04-16"),
                    DateStarted = DateTime.Parse("2014-04-16"), DateEnded = DateTime.Parse("2014-04-19"),
                    TimeOut = DateTime.Parse("10:50:00"), ExposureTime = "72 hours"
                },
                new Test
                {
                    Customer = "MPact", CustomerContact = "Russ", LabTechAssigned = "Patrick", MudType = "OBM",
                    MudSystemName = "Versadril", ReceivedDate = DateTime.Parse("2014-07-30"),
                    DateStarted = DateTime.Parse("2014-08-02"), DateEnded = DateTime.Parse("2014-08-10"),
                    TimeOut = DateTime.Parse("14:52:00"), ExposureTime = "192 hours"
                }
            };
            foreach (Test t in tests)
            {
                context.Tests.Add(t);
            }

            context.SaveChanges();



            // seed Test Data Table
            var testData = new TestData[]
            {
                new TestData
                {
                    CompoundID = 1, TestTemp = 138, S1Thickness = 2.11, S1Hardness_a = 79,
                    S1Hardness_b = 71, S1WtAir_a = 0.727, S1WtAir_b = 0.811, S1WtWater_a = 0.108, S1WtWater_b = 0.099,
                    S1_25Mod = 60, S1_50Mod = 134, S1_100Mod = 272, S1_elongation = 359, S1_tensile = 2048
                },
                new TestData
                {
                    CompoundID = 2, TestTemp = 250, S1Thickness = 2.04, S1Hardness_a = 90,
                    S1Hardness_b = 85, S1WtAir_a = 0.707, S1WtAir_b = 0.801, S1WtWater_a = 0.110, S1WtWater_b = 0.105,
                    S1_25Mod = 177, S1_50Mod = 386, S1_100Mod = 980, S1_elongation = 196, S1_tensile = 2241
                }
                //new TestData
                //{
                //    TestID = 3, CompoundID = 3, TestTempID = 3, S1Thickness = 2.32, S1Hardness_a = 89,
                //    S1Hardness_b = 92, S1WtAir_a = 0.715, S1WtAir_b = .790, S1WtWater_a = 0.1112, S1WtWater_b = 0.115,
                //    S1_25Mod = 200, S1_50Mod = 300, S1_100Mod = 400, S1_elongation = 268, S1_tensile = 1965
                //},
                //new TestData
                //{
                //    TestID = 4, CompoundID = 2, TestTempID = 3, S1Thickness = 2.11, S1Hardness_a = 79,
                //    S1Hardness_b = 71, S1WtAir_a = 0.727, S1WtAir_b = .811, S1WtWater_a = 0.108, S1WtWater_b = 0.099,
                //    S1_25Mod = 60, S1_50Mod = 134, S1_100Mod = 272, S1_elongation = 359, S1_tensile = 2048
                //},
                //new TestData
                //{
                //    TestID = 5, CompoundID = 4, TestTempID = 3, S1Thickness = 2.04, S1Hardness_a = 95,
                //    S1Hardness_b = 92, S1WtAir_a = 0.717, S1WtAir_b = .805, S1WtWater_a = 0.106, S1WtWater_b = 0.100,
                //    S1_25Mod = 298, S1_50Mod = 354, S1_100Mod = 565, S1_elongation = 268, S1_tensile = 1988
                //}
            };

            foreach (TestData s in testData)
            {
                context.Datas.Add(s);
            }

            context.SaveChanges();

        }



    }
}