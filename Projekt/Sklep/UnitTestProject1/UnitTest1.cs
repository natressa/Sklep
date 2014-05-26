using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sklep;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void stworzProduktTest()
        {
            Product k = new Product();

            k.NAME = "koza";
            k.PRICE = 10;
            k.SIZE = "XL";
            string actualNAME = k.NAME;
            double actualPRICE = k.PRICE;
            string actualSIZE = k.SIZE;

            string expectedNAME = "koza";
            double expectedPRICE = 10;
            string expectedSIZE = "XL";

            Assert.AreEqual(expectedNAME, actualNAME);
            Assert.AreEqual(expectedSIZE, actualSIZE);
            Assert.AreEqual(expectedPRICE, actualPRICE);

        }
    }
}
