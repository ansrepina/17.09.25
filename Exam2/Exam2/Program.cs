using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        //Кортеж(Tuple) — это структура данных, которая позволяет объединить несколько значений в одну группу.
        //Значения мб разных типов. Кортежи реализованы как типы-значения(ValueTuple)
        //Хранятся в стеке, что делает их очень быстрыми.

        //   1.Декларация и инициализация. Записывается в виде(x1, x2, …, xn)

        // Явнo:
         (int, string) person2 = (30, "Марина");
        // Неявно:
         var person = (25, "Иван");

        //   2.Типизация и именование полей

        //Полям кортежа можно давать имена, чтобы обращаться к ним по этим
        //именам (вместо Item1, Item2 ...):
        //Способы именования:
        //  1.При объявлении типа:
        (int Age, string Name) user = (25, "Алексей");
        Console.WriteLine(user.Name);

        //  2.При инициализации:
        var score = (Value: 100, Game: "Chess");
        Console.WriteLine(score.Value);

        //К полям кортежа можно обращаться через точку:
        var t = (4, 23);
        var x = t.Item1; 

        //Методы могут возвращать значения-кортежи или принимать
        //кортежи - параметры:
          static (double, double) RotateVector((double x, double y) vector, double angleInDegrees)
             {
                  throw new NotImplementedException();
             }

        //   3.Обмен значениями:

        int a = 5; int b = 10;
        (a, b) = (b, a);


        //Пример использования

        var weather = (City: "Екатеринбург", Temp: -20, IsSnow: true);
        if (weather.Item3)
        {
            Console.WriteLine($"В городе {weather.City} сейчас {weather.Temp} градусов, идет снег");
        }
    }
}
