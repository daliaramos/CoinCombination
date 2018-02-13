using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CoinCombination.Models;

namespace CoinCombination.Controllers
{
  public class CoinCombinationController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/")]
    public ActionResult Display()
    {
      CoinCombinationGenerator newCoinCombination = new CoinCombinationGenerator();
      int cents = Int32.Parse(Request.Form["cents"]);
      int quarters = newCoinCombination.CalculateQuarters(cents);
      int dimes = newCoinCombination.CalculateDimes(cents - (quarters * 25));
      int nickels = newCoinCombination.CalculateNickels(cents - (quarters * 25) - (dimes * 10));
      int pennies = newCoinCombination.CalculatePennies(cents - (quarters * 25) - (dimes * 10) - (nickels * 5));
      newCoinCombination.SetQuarters(quarters);
      newCoinCombination.SetDimes(dimes);
      newCoinCombination.SetNickels(nickels);
      newCoinCombination.SetPennies(pennies);
      newCoinCombination.SetTotalCents(cents);
      return View(newCoinCombination);
    }

  }
}
