using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    static class RailFence
    {
        public static string Encrypt(string plainText, int key)
        {
            char[,] matrix = new char[key, plainText.Length];
            bool direction = true;
            int row = 0, column = 0;

            for (int i = 0; i < plainText.Length; i++)
            {
                matrix[row, column] = plainText[i];
                column++;

                if (direction)
                    row++;
                else
                    row--;

                if (row == 0 || row == key - 1)
                    direction = !direction;
            }

            string cipherText = "";
            foreach (char c in matrix)
                if (c != 0)
                    cipherText += c;

            return cipherText;
        }

        public static string Decrypt(string cipherText, int key) 
        {
            char[,] matrix = new char[key, cipherText.Length];
            bool direction = true;
            int row = 0, column = 0;

            for (int i = 0; i < cipherText.Length; i++)
            {
                matrix[row, column] = 'a';
                column++;

                if (direction)
                    row++;
                else
                    row--;

                if (row == 0 || row == key - 1)
                    direction = !direction;
            }

            int index = 0;
            for (int i = 0; i < key; i++)
                for (int j = 0; j < cipherText.Length; j++)
                    if (matrix[i, j] == 'a')
                        matrix[i, j] = cipherText[index++];

            string plainText = "";
            direction = true;
            row = 0; 
            column = 0;

            for (int i = 0; i < cipherText.Length; i++)
            {
                plainText += matrix[row, column];
                column++;

                if (direction)
                    row++;
                else
                    row--;

                if (row == 0 || row == key - 1)
                    direction = !direction;
            }

            return plainText;
        }
    }
}
