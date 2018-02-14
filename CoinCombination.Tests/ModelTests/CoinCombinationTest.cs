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

    [TestMethod]
    public void CoinCombination_CalculatePennies_Int()
    {
      CoinCombinationGenerator testCoinCombination = new CoinCombinationGenerator();
      Assert.AreEqual(3, testCoinCombination.CalculatePennies(3));
    }

    [TestMethod]
    public void CoinCombination_CalculateAllCoins_List()
    {
      CoinCombinationGenerator testCoinCombination = new CoinCombinationGenerator();
      List<int> coinsList = new List<int>(){2,1,1,3};
      CollectionAssert.AreEqual(coinsList, testCoinCombination.CalculateAllCoins(68));
    }
  }
}
