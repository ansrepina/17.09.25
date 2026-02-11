using System;

namespace Exam
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите четное число (>= 4): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 4 && n % 2 == 0)
            {
                bool found = false;

                for (int i = 2; i <= n / 2; i++)
                {
                    if (IsPrime(i) && IsPrime(n - i))
                    {
                        Console.WriteLine($"{n} = {i} + {n - i}");
                        found = true;
                        break; 
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Контрпример найден");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное четное число не меньше 4.");
            }
        }
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            // Проверяем делители от 3 до корня из числа с шагом 2
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}


