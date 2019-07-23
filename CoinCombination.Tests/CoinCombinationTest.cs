using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombination.Models;

namespace CoinCombination.Tests
{
    [TestClass]
    public class CoinCombinationTest
    {
        [TestMethod]
        public void CoinCalculator_CatchesQuarters_Quater3()
        {
            changeCalc dollar = new changeCalc();
            Assert.AreEqual("Quarter: 3 Dime: 2 Nickel: 0 Penny: 4", dollar.CoinCalculator(99));
        }
    }
}