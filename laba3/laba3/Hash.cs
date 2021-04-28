using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace laba3
{
    class Hash
    {
        public static BigInteger GetHash(string message, BigInteger n, BigInteger h)
        {
            foreach (var m in message)
            {
                h = RSA.FastExponentiation(h + m, 2, n);
            }

            return h;
        }
    }
}
