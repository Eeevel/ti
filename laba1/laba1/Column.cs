using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    static class Column
    {
        public static string Encrypt(string plainText, string key) 
        {
            string cipherText = "";

            char[] delimiterChars = { ' ', ',', '.', ':', '-' };
            string[] sNumbers = key.Split(delimiterChars);
            int[] numbers;
            try
            {
                numbers = Array.ConvertAll(sNumbers, int.Parse);
            }
            catch
            {
                cipherText = "Неверный ключ";
                return cipherText;
            }

            int columnCount = numbers.Length;
            int rowsCount = (int)Math.Ceiling((double)plainText.Length / columnCount);
            char[,] matrix = new char[rowsCount, columnCount];

            // Заполнение матрицы символами текста
            int index = 0;
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnCount; j++)
                    if (index < plainText.Length)
                        matrix[i, j] = plainText[index++];
                    else
                        matrix[i, j] = '\r';

            // Чтение столбцов по ключу
            int column;
            index = 0;
            for (int i = 0; i < columnCount; i++)
            {
                column = numbers[index++] - 1;
                for (int j = 0; j < rowsCount; j++)
                    cipherText += matrix[j, column];
            }

            // Удаление лишних символов
            index = cipherText.Length;
            for (int i = 0; i < index; i++)
            {
                if (cipherText[i] == '\r')
                {
                    cipherText = cipherText.Remove(i, 1);
                    index--;
                }
                    
            }

            return cipherText;
        }

        public static string Decrypt(string cipherText, string key)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '-' };
            string[] sNumbers = key.Split(delimiterChars);
            int[] numbers;
            try
            {
                numbers = Array.ConvertAll(sNumbers, int.Parse);
            }
            catch
            {
                cipherText = "Неверный ключ";
                return cipherText;
            }

            int columnCount = numbers.Length;
            int rowsCount = (int)Math.Ceiling((double)cipherText.Length / columnCount);
            char[,] matrix = new char[rowsCount, columnCount];

            // Заполняем лишние ячейки
            int freeCells = columnCount * rowsCount - cipherText.Length;
            for (int i = freeCells; i > 0; i--)
                matrix[rowsCount - 1, columnCount - i] = '\r';

            // Запись столбцов по ключу
            int column;
            int index = 0;
            int indexText = 0;
            for (int i = 0; i < columnCount; i++)
            {
                column = numbers[index++] - 1;
                for (int j = 0; j < rowsCount; j++)
                    if(matrix[j, column] != '\r')
                        matrix[j, column] = cipherText[indexText++];
            }

            // Получение текста из матрицы
            string plainText = "";
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnCount; j++)
                    if (matrix[i, j] != '\r')
                        plainText += matrix[i, j];

            return plainText;
        }
    }
}
