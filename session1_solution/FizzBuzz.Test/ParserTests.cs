using System;
using FizzBuzz.Domain;
using FizzBuzz.Core;
using Xunit;

namespace FizzBuzz.Test
{
    public class ParserTests
    {
        public const string FIZZ= "Fizz";
        public const string BUZZ = "Buzz";

        private readonly IFizzBuzzParser sut;
        
        public ParserTests() {
          this.sut = new FizzBuzzParser();
        }


        [Theory]
        [InlineData(1,"1")]
        [InlineData(-1, "-1")]
        [InlineData(8, "8")]
        [InlineData(103, "103")]
        public void Parse_NoMultiples_ReturnInputNumber(int n, string str)
        {
            // arrange
            var expected = str;

            // act
            var actual = sut.Parse(n);

            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(-3)]
        [InlineData(81)]
        [InlineData(132)]
        public void Parse_MultipleOf3_ReturnFizz(int n)
        {
            var expected = FIZZ;
            var actual = sut.Parse(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(-25)]
        [InlineData(80)]
        [InlineData(130)]
        public void Parse_MultipleOf5_ReturnFuzz(int n)
        {
            var expected = BUZZ;
            var actual = sut.Parse(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(-45)]
        [InlineData(90)]
        public void Parse_MultipleOf3And5_ReturnFuzz(int n)
        {
            var expected = FIZZ+BUZZ;
            var actual = sut.Parse(n);
            Assert.Equal(expected, actual);
        }
    }
}
