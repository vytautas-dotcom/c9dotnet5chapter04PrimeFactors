using static System.Console;
using PrimeFactorsLib;


namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            var getPrimeString = new PrimeFactorsCalculator();
            WriteLine(getPrimeString.Factors(359));
        }
    }
}
