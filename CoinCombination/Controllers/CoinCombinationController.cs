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

      return View();
    }

  }
}
