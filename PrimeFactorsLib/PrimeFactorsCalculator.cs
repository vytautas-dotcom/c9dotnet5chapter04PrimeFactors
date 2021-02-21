using System;
using System.Collections.Generic;

namespace PrimeFactorsLib
{
    public class PrimeFactorsCalculator
    {
        public bool IsPrime(int num)
        {
            bool isPrime = true;

            if (num == 2) return isPrime;
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false; break;
                    }
                }
            }

            return isPrime;
        }
        public int GiveNextPrime(int num)
        {
            if (IsPrime(num))
            {
                while (true)
                {
                    if (IsPrime(++num))
                    {
                        return num;
                    }
                }
            }
            else return num;
        }
        public string Factors(int num)
        {
            List<int> factors = new List<int>();
            int divider = 2;
            while (num != 1)
            {
                if (num % divider == 0)
                {
                    factors.Add(divider);
                    num /= divider;
                }
                else
                {
                    divider = GiveNextPrime(divider);
                }
            }
            return ArrayToString(factors);
        }

        public string ArrayToString(List<int> arr)
        {
            string factors = string.Empty;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                factors += arr[i].ToString() + "*";
            }
            return factors += arr[arr.Count - 1];
        }
    }
}
