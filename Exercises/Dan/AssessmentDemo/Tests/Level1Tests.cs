using Assessment.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Test
{
    [TestClass]
    public class Level1Tests
    {
        // Create a class "Country" and make the following test pass.

        [TestMethod]
        public void country_sweden()
        {
            // Create a country with the name "Sweden"
            var d = new Country("Sweden");

            // Add skiresorts with number of lifts
            d.AddSkiResort("Vemdalen", 20);    // the skiresort "Vemdalen" has 20 lifts
            d.AddSkiResort("Sälen", 64);
            d.AddSkiResort("Åre", 25);

            //There are 20 + 64 + 25 = 109 lifts in Sweden
            //    Create two methods. One of the methods should use LINQ(and the other not)
            Assert.AreEqual(109, d.TotalNumberOfLifts());
            Assert.AreEqual(109, d.TotalNumberOfLifts_Linq());

                // GetName should give COUNTRY and then the name in uppercase
                Assert.AreEqual("COUNTRY SWEDEN", d.GetName());

            // SkiResortNames should return a list of all skiResortNames
            var skiResortNames = d.SkiResortNames();
            var skiResortNames_linq = d.SkiResortNames_Linq();

            Assert.AreEqual(3, skiResortNames.Count);
            Assert.AreEqual("Vemdalen", skiResortNames[0]);
            Assert.AreEqual("Sälen", skiResortNames[1]);
            Assert.AreEqual("Åre", skiResortNames[2]);

            // The following checks that "SkiResortNames_Linq" also returns correct values
            CollectionAssert.AreEqual(skiResortNames, skiResortNames_linq);

            // "maxlifts" should tell the maximum number of lifts in a skiresort in this country
            // create two methods. one of the methods should use linq (and the other not)
            Assert.AreEqual(64, d.MaxLifts());
            Assert.AreEqual(64, d.MaxLifts_Linq());
        }

        [TestMethod]
        public void country_zzz()
        {
            var d = new Country("zzz");
            d.AddSkiResort("AA", 4);
            d.AddSkiResort("BB", 8);
            d.AddSkiResort("CC", 2);
            d.AddSkiResort("DD", 1);

            Assert.AreEqual(15, d.TotalNumberOfLifts());
            Assert.AreEqual(15, d.TotalNumberOfLifts_Linq());

            Assert.AreEqual("COUNTRY ZZZ", d.GetName());

            var skiResortNames = d.SkiResortNames();
            var skiResortNames_linq = d.SkiResortNames_Linq();

            Assert.AreEqual(4, skiResortNames.Count);
            Assert.AreEqual("AA", skiResortNames[0]);
            Assert.AreEqual("BB", skiResortNames[1]);
            Assert.AreEqual("CC", skiResortNames[2]);
            Assert.AreEqual("DD", skiResortNames[3]);

            CollectionAssert.AreEqual(skiResortNames, skiResortNames_linq);

            Assert.AreEqual(8, d.MaxLifts());
            Assert.AreEqual(8, d.MaxLifts_Linq());
        }

        [TestMethod]
        public void country_yyy()
        {
            var d = new Country("yyy");
            d.AddSkiResort("AA", 20);
            d.AddSkiResort("BB", 19);

            Assert.AreEqual(39, d.TotalNumberOfLifts());
            Assert.AreEqual(39, d.TotalNumberOfLifts_Linq());

            Assert.AreEqual("COUNTRY YYY", d.GetName());

            var skiResortNames = d.SkiResortNames();
            var skiResortNames_linq = d.SkiResortNames();

            Assert.AreEqual(2, skiResortNames.Count);
            Assert.AreEqual("AA", skiResortNames[0]);
            Assert.AreEqual("BB", skiResortNames[1]);

            CollectionAssert.AreEqual(skiResortNames, skiResortNames_linq);

            Assert.AreEqual(20, d.MaxLifts());
            Assert.AreEqual(20, d.MaxLifts_Linq());
        }
    }
}
