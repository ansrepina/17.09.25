using System;

namespace Homework3
    {
    internal class Program
    {
         public static void Main(string[] args)
         {    
            Console.WriteLine("Введите количество секунд, прошедших с начала суток:");
            string x = Console.ReadLine(); 
            int totalSeconds = int.Parse(x);  

            int hours = totalSeconds / 3600; 
            int remainingSecondsAfterHours = totalSeconds % 3600; 
            int minutes = remainingSecondsAfterHours / 60;
            int seconds = remainingSecondsAfterHours % 60;

            Console.WriteLine($"Это {hours} ч. {minutes} мин. {seconds} с.");
         }
    }
}

