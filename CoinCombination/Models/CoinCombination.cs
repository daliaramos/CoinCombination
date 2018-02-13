using System.Collections.Generic;
using System;

namespace CoinCombination.Models
{
  public class CoinCombinationGenerator
  {
    private int _quarters;
    private int _dimes;
    private int _nickels;
    private int _pennies;
    private int _totalCents;

    // public CoinCombinationGenerator()
    // {
    //
    // }

    public int GetQuarters()
    {
      return _quarters;
    }

    public void SetQuarters(int quarters)
    {
      _quarters = quarters;
    }

    public int GetDimes()
    {
      return _dimes;
    }

    public void SetDimes(int dimes)
    {
      _dimes = dimes;
    }

    public int GetNickels()
    {
      return _nickels;
    }

    public void SetNickels(int nickels)
    {
      _nickels = nickels;
    }

    public int GetPennies()
    {
      return _pennies;
    }

    public void SetPennies(int pennies)
    {
      _pennies = pennies;
    }

    public int GetTotalCents()
    {
      return _totalCents;
    }

    public void SetTotalCents(int totalCents)
    {
      _totalCents = totalCents;
    }

    public int CalculateQuarters(int cents)
    {
      return (cents / 25);
    }

    public int CalculateDimes(int cents)
    {
      return (cents / 10);
    }

    public int CalculateNickels(int cents)
    {
      return (cents / 5);
    }

    public int CalculatePennies(int cents)
    {
      return cents;
    }
  }
}
