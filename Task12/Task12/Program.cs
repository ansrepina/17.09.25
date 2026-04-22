using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            while (true)
            {
                Console.WriteLine("Введите через пробел два натуральных числа n и m от 5 до 20");
                Console.WriteLine("(Enter - отказ от ввода)");
                var input = Console.ReadLine();

                if (input == string.Empty)
                    return;

                var strings = input.Split();

                if (strings.Length == 2 && int.TryParse(strings[0], out m) &&
                    int.TryParse(strings[1], out n) && 5 <= m && m <= 20 &&
                    5 <= n && n <= 20)
                    break;
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }
            }

            var matrix = new int[m, n];

            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(0, 100);

            PrintTable(matrix);


            var zeroPosition = FindZeroIndex(matrix);

            Console.WriteLine();

            if (zeroPosition.HasValue)
            {
                Console.WriteLine($"Найден элемент, равный 0. Индексы: [{zeroPosition.Value.Row}, {zeroPosition.Value.Column}]");
            }
            else
            {
                Console.WriteLine("Элементов, равных 0, в матрице не найдено.");
            }


            int[] diffs = Calculation(matrix);

            Console.WriteLine("Разность сумм чётных и нечётных элементов по строкам:");
            for (int i = 0; i < diffs.Length; i++)
                Console.WriteLine($"Строка {i+1}: {diffs[i]}");
        }



        static void PrintTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    Console.Write($"{table[i, j],2} ");

                Console.WriteLine();
            }
        }

        static (int Row, int Column)? FindZeroIndex(int[,] table)
        {

            for (int i = 0; i < table.GetLength(0); i++) // table.GetLength(0) - количество строк
            {
                for (int j = 0; j < table.GetLength(1); j++) //table.GetLength(1) - количество столбцов
                {
                    if (table[i, j] == 0)
                    {
                        return (i, j);
                    }
                }
            }

            return null;
        }

        static int[] Calculation(int[,] table)
        {
            
            int[] diffs = new int[table.GetLength(0)];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                int evensum = 0;
                int oddsum = 0;

                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] % 2 == 0)

                        evensum += table[i, j];
                    else
                        oddsum += table[i, j];
                }

                diffs[i] = evensum - oddsum;

            }

            return diffs;

        }

    }
}


