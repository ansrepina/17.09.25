using System;

class Program
{
    static void Main()
    {
        string source = "микросхема";

        // IndexOf - метод строки
        int posK = source.IndexOf('к');       
        int posO = source.IndexOf('о');       
        int posS = source.IndexOf('с');       
        int posH = source.IndexOf('х');       
        int posE = source.IndexOf('е');       
        int posM = source.IndexOf('м');   

        string os = source.Substring(posO, 2);            // "ос" (от 'о' длина 2 -> "ос")
        string k = source.Substring(posK, 1);             
        string m = source.Substring(posM, 1);             

        string kosmos = k + os + m + os;                  // склейка 

        string s = source.Substring(posS, 1);             
        string e = source.Substring(posE, 1);             
        string h = source.Substring(posH, 1);             

        string smeh = s + m + e + h;                      

        Console.WriteLine("Исходное слово: " + source);
        Console.WriteLine("Собираем слово 1: " + kosmos);
        Console.WriteLine("Собираем слово 2: " + smeh);
    }
}
