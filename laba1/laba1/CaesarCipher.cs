using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    static class CaesarCipher
    {
        public static string Encrypt(string plainText, int key)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int index = 0;
            string cipherText = "";
            char c;

            while (index < plainText.Length)
            {
                c = plainText[index];

                if (c == ' ' || c == '.' || c == ',' || c == '-' || c == '!' || c == '?' || c == ';')
                {
                    cipherText += c;
                    index++;
                }
                else
                {
                    c = alphabet[(plainText[index++] - 'A' + key) % alphabet.Length];
                    cipherText += c;
                }
            }

            return cipherText;
        }

        public static string Decrypt(string cipherText, int key)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int index = 0;
            string plainText = "";
            char c;

            while (index < cipherText.Length)
            {
                c = cipherText[index];

                if (c == ' ' || c == '.' || c == ',' || c == '-' || c == '!' || c == '?' || c == ';')
                {
                    plainText += c;
                    index++;
                }
                else
                {
                    c = alphabet[(cipherText[index++] - 'A' - key + alphabet.Length) % alphabet.Length];
                    plainText += c;
                }
            }

            return plainText;
        }
    }
}
