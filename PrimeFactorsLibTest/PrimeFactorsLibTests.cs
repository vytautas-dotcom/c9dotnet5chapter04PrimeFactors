using PrimeFactorsLib;
using Xunit;
using System.Collections.Generic;

namespace PrimeFactorsLibTest
{
    public class PrimeFactorsLibTests
    {
        [Fact]
        public void Is7GivenNumberPrimeOrNot()
        {
            int a = 9;
            bool expected = false;
            var checker = new PrimeFactorsCalculator();

            bool actual = checker.IsPrime(a);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Is31GivenNumberPrimeOrNot()
        {
            int a = 12;
            bool expected = false;
            var checker = new PrimeFactorsCalculator();

            bool actual = checker.IsPrime(a);

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void GiveNextPrimeNumber()
        {
            int a = 17;
            int expected = 19;
            var calculator = new PrimeFactorsCalculator();

            int actual = calculator.GiveNextPrime(a);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GiveStringFromArray()
        {
            List<int> a = new List<int>(){2, 2, 3, 5, 7, 11};
            string expected = "2*2*3*5*7*11";
            var stringArray = new PrimeFactorsCalculator();

            string actual = stringArray.ArrayToString(a);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GiveAllPrimeFactorsOfGivenNumber()
        {
            int a = 10;
            string expected = "2*5";
            var allFactors = new PrimeFactorsCalculator();

            string actual = allFactors.Factors(a);

            Assert.Equal(expected, actual);
        }

        
    }
}
