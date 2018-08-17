using System;
using FizzBuzz.Domain;

namespace FizzBuzz.Core
{
  public class FizzBuzzParser : IFizzBuzzParser
  {
    public const string FIZZ = "Fizz";
    public const string FUZZ = "Fuzz";

    public string Parse(int n)
    {
      var rt = string.Empty;

      if (n % 3 == 0) rt += FIZZ;
      if (n % 5 == 0) rt += FUZZ;
      return  String.IsNullOrEmpty(rt) ? $"{n}" : rt;
    }
  }
}
