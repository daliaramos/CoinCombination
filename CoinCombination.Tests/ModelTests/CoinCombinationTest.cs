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

    [TestMethod]
    public void CoinCombination_CalculateDimes_Int()
    {
      CoinCombinationGenerator testCoinCombination = new CoinCombinationGenerator();
      Assert.AreEqual(1, testCoinCombination.CalculateDimes(18));
    }

    [TestMethod]
    public void CoinCombination_CalculateNickels_Int()
    {
      CoinCombinationGenerator testCoinCombination = new CoinCombinationGenerator();
      Assert.AreEqual(1, testCoinCombination.CalculateNickels(8));
    }
  }
}
