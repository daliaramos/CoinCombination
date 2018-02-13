using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using CoinCombination;

namespace CoinCombination.Tests
{
  [TestClass]
  public class CoinCombinationTest
  {
    [TestMethod]
    public void CoinCombination_CalculateQuarters_Int()
    {
      CoinCombinationGenerator testCoinCombination = new CoinCombinationGenerator();
      Assert.AreEqual(2, testCoinCombination.CalculateQuarters(68));
    }
  }
}
