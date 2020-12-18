using System;
using System.Collections.Generic;

namespace Codewars.GapOfPrimes
{
    internal class GapInPrimes
    {
        public static long[] Gap(int gap, long startSearch, long endSearch)
        {
            // your code
            var primes = GeneratePrimeNumbers(startSearch, endSearch);

            long[] gapsSet = null;

            for (int i = 0; i < primes.Count; i++)
            {
                if (primes.Count == 1)
                {
                   break;
                }

                var current = primes[i];
                var next = (i != primes.Count-1)? primes[i + 1] : primes[i];

                if ((next - current) == gap)
                {
                    gapsSet = new long[] { current, next };
                    break;
                }
            }

            return gapsSet;
         }

        private static List<long> GeneratePrimeNumbers(long start, long end)
        {
            List<long> primes = new List<long>();
            for (var currentNumber = (int) start; currentNumber <= end; currentNumber++)
            {
                if (IsPrime(currentNumber))
                {
                   primes.Add(currentNumber);
                }
            }

            return primes;
        }

        private static bool IsPrime(int n)
        {
            if (n <= 1 || n % 2 == 0) return false;
            if (n == 2) return true;

            var boundary = Math.Floor(Math.Sqrt(n));

            for (var i = 3; i <= boundary; i += 2)
            {
                if (n % i == 0)
                {
                   return false;
                }
            }

            return true;
        }
    }
}