using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        public static void Main()
        {

            Console.WriteLine("Введите текст в одну строку:");
            string inputText = Console.ReadLine();

            string[] wordsArray = Regex.Replace(inputText, @"[^\w\s]", "").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            PrintArrayElements(wordsArray);

            CapitalizeFirstLetter(wordsArray);

            Console.WriteLine("\nМассив после изменения регистра первой буквы каждого слова:");
            PrintArrayElements(wordsArray);

            double averageLength = CalculateAverageWordLength(wordsArray);
            Console.WriteLine($"\nСреднее арифметическое длины слов: {averageLength}");

            string[] reversedWords = ReverseWords(wordsArray);
            Console.WriteLine("\nМассив слов с обратным порядком символов:");
            PrintArrayElements(reversedWords);
        }

        static void PrintArrayElements(string[] array)
        {
            Console.WriteLine("Исходный массив слов:");
            foreach (string word in array)
            {
                Console.WriteLine(word);
            }
        }

        static void CapitalizeFirstLetter(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!string.IsNullOrEmpty(array[i]))
                {
                    array[i] = char.ToUpper(array[i][0]) + array[i].Substring(1);
                }
            }
        }
        static double CalculateAverageWordLength(string[] array)
        {
            int totalLength = 0;
            foreach (string word in array)
            {
                totalLength += word.Length;
            }
            return (double)totalLength / array.Length;
        }

        static string[] ReverseWords(string[] array)
        {
            string[] reversedArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                char[] charArray = array[i].ToCharArray();
                Array.Reverse(charArray);
                reversedArray[i] = new string(charArray);
            }
            return reversedArray;
        }
    }
}
