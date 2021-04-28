using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    static class PrimeNumber
    {
        private static Random random = new Random();

        public static bool IsPrimeNumber(long n)
        {
            if (n > 1)
            {
                for (var i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        public static long Generate()
        {
            var numbers = new List<long>();
            long min = 1000, max = 5000;

            while (min++ < max)
            {
                if (IsPrimeNumber(min))
                {
                    numbers.Add(min);
                }
            }

            return numbers[random.Next(0, numbers.Count)];
        }
    }
}