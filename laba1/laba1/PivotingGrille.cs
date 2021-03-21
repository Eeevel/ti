using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    static class PivotingGrille
    {
        private static bool[,] mask;
        private static int size = 5;

        private static void Initialize(string key)
        {
            mask = new bool[size, size];
            int index = 0;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (key[index++] == '0')
                        mask[i, j] = true;
                    else
                        mask[i, j] = false;
        }

        public static string Encrypt(string plainText, string key) 
        {
            Initialize(key);
            int index = 0;
            char[,] matrix = new char[size, size];
            string cipherText = "";
            bool saveCenter = mask[size / 2, size / 2]; 

            while (plainText.Length % (size * size) != 0)
                plainText += ' ';

            while (index < plainText.Length)
            {
                // 1 проход
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        if (mask[i, j])
                            matrix[i, j] = plainText[index++];

                if (mask[size / 2, size / 2])
                    mask[size / 2, size / 2] = false;

                // Поворот на 90 градусов
                for (int i = 0; i < size; i++)
                    for (int j = size - 1; j >= 0; j--)
                        if (mask[j, i])
                            matrix[i, (size - 1) - j] = plainText[index++];

                // Поворот на 180 градусов
                for (int i = size - 1; i >= 0; i--)
                    for (int j = size - 1; j >= 0; j--)
                        if (mask[i, j])
                            matrix[(size - 1) - i, (size - 1) - j] = plainText[index++];

                // Поворот на 270 градусов
                for (int i = size - 1; i >= 0; i--)
                    for (int j = 0; j < size; j++)
                        if (mask[j, i])
                            matrix[(size - 1) - i, j] = plainText[index++];

                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        cipherText += matrix[i, j];

                mask[size / 2, size / 2] = saveCenter;
            }

            return cipherText;
        }


        public static string Decrypt(string cipherText, string key) 
        {
            Initialize(key);
            int index = 0;
            char[,] matrix = new char[size, size];
            string plainText = "";
            bool saveCenter = mask[size / 2, size / 2];

            while (cipherText.Length % (size * size) != 0)
                cipherText += ' ';

            while (index < cipherText.Length)
            {
                // Заполнение матрицы зашифрованным текстом
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        matrix[i, j] = cipherText[index++];

                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        if (mask[i, j])
                            plainText += matrix[i, j];

                if (mask[size / 2, size / 2])
                    mask[size / 2, size / 2] = false;

                for (int i = 0; i < size; i++)
                    for (int j = size - 1; j >= 0; j--)
                        if (mask[j, i])
                            plainText += matrix[i, (size - 1) - j];

                for (int i = size - 1; i >= 0; i--)
                    for (int j = size - 1; j >= 0; j--)
                        if (mask[i, j])
                            plainText += matrix[(size - 1) - i, (size - 1) - j];

                for (int i = size - 1; i >= 0; i--)
                    for (int j = 0; j < size; j++)
                        if (mask[j, i])
                            plainText += matrix[(size - 1) - i, j];

                mask[size / 2, size / 2] = saveCenter;
            }

            return plainText;
        }
    }
}
