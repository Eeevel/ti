using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace laba2
{
    class RSA
    {
        public long p, q, e, d, n, functionEuler;

        public static string Encrypt(string plainText, long e, long n)
        {
            string chiperText = "";

            for (int i = 0; i < plainText.Length; i++)
            {
                var number = FastExponentiation((int)plainText[i], e, n);
                chiperText += number.ToString() + ' ';
            }

            return chiperText;
        }

        public static string Decrypt(string chiperText, long d, long n)
        {
            string plainText = "";
            string[] arrChiperText = chiperText.Trim(' ').Split(' ');

            for (int i = 0; i < arrChiperText.Length; i++)
            {
                var value = BigInteger.Parse(arrChiperText[i]); ;
                var number = FastExponentiation(value, d, n);
                plainText += (char)number;
            }

            return plainText;
        }

        public RSA()
        {
            p = PrimeNumber.Generate();
            q = PrimeNumber.Generate();

            n = p * q;
            functionEuler = (p - 1) * (q - 1);

            e = GetPublicKey(functionEuler);
            d = GetPrivateKey(e, functionEuler);
        }

        public RSA(long pUser, long qUser, long eUser)
        {
            if (PrimeNumber.IsPrimeNumber(pUser) && PrimeNumber.IsPrimeNumber(qUser))
            {
                p = pUser;
                q = qUser;
            }
            else
            {
                throw new ArgumentException("Числа p и q не простые");
            }

            n = p * q;
            functionEuler = (p - 1) * (q - 1);

            if ((PrimeNumber.IsPrimeNumber(eUser)) &&
                (eUser < functionEuler) &&
                (BigInteger.GreatestCommonDivisor(new BigInteger(eUser), new BigInteger(functionEuler)) == BigInteger.One))
            {
                e = eUser;
            }
            else
            {
                throw new ArgumentException("Число е не подходит");
            }

            d = GetPrivateKey(e, functionEuler);
        }

        private long GetPublicKey(long functionEuler)
        {
            long e = functionEuler - 1;

            while (true)
            {
                if ((PrimeNumber.IsPrimeNumber(e)) && 
                    (e < functionEuler) && 
                    (BigInteger.GreatestCommonDivisor(new BigInteger(e), new BigInteger(functionEuler)) == BigInteger.One))
                {
                    break;
                }
                e--;
            }

            return e;
        }

        private long GetPrivateKey(long a, long m)
        {
            long x = 0, y = 0;
            long g = Gcd(a, m, ref x, ref y);
            if (g != 1)
                return 0;
            else
            {
                x = (x % m + m) % m;
                return x;
            }
        }

        private long Gcd(long a, long b, ref long x, ref long y)
        {
            if (a == 0)
            {
                x = 0; y = 1;
                return b;
            }
            long x1 = 0, y1 = 0;
            long d = Gcd(b % a, a, ref x1, ref y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        private static BigInteger FastExponentiation(BigInteger a, BigInteger z, BigInteger n)
        {
            BigInteger a1 = a, z1 = z, x = 1;
            while (z1 != 0)
            {
                while (z1 % 2 == 0)
                {
                    z1 /= 2;
                    a1 = (a1 * a1) % n;
                }

                z1 -= 1;
                x = (x * a1) % n;
            }

            return x;
        }
    }
}
