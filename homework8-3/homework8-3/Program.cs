using System;

public class Program
{
    static bool DecodePosition(string position, out int row, out int col)
    {
        row = position[1] - '1';
        col = position[0] - 'a';
        return true;
    }
    static bool IsBishopAttacking(int bishopRow, int bishopCol, int targetRow, int targetCol)
    {
        return Math.Abs(bishopRow - targetRow) == Math.Abs(bishopCol - targetCol);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите позицию белого слона (например, a1):");
        string whitePosition = Console.ReadLine();

        Console.WriteLine("Введите позицию черного слона (например, h8):");
        string blackPosition = Console.ReadLine();

        DecodePosition(whitePosition, out int whiteRow, out int whiteCol);
        DecodePosition(blackPosition, out int blackRow, out int blackCol);

        bool blackAttacksWhite = IsBishopAttacking(blackRow, blackCol, whiteRow, whiteCol);

        bool whiteAttacksBlack = IsBishopAttacking(whiteRow, whiteCol, blackRow, blackCol);

        if (blackAttacksWhite)
            Console.WriteLine("Белый слон находится под боем черного слона.");
        else
            Console.WriteLine("Белый слон не находится под боем черного слона.");

        if (whiteAttacksBlack)
            Console.WriteLine("Черный слон находится под боем белого слона.");
        else
            Console.WriteLine("Черный слон не находится под боем белого слона.");

        Console.ReadKey(); 
    }
}


