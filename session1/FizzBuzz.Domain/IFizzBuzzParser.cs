using System;

namespace FizzBuzz.Domain
{
    public interface IFizzBuzzParser
    {
      /// <summary>
      /// Parse an integer to Fizz Buzz string
      /// </summary>
      /// <param name="n">Input number to use</param>
      /// <returns>string respentation</returns>
      string Parse(int n);
    }
}
