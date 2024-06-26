using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.Write($"{f1.GetFractionString()}\n");
        Fraction f2 = new Fraction(5);
        Console.Write($"{f2.GetFractionString()}\n");
        Fraction f3 = new Fraction(3, 4);
        Console.Write($"{f3.GetFractionString()}\n");
        f1.SetTop(1);
        f1.SetBottom(3);
        Console.Write($"{f1.GetBottom()}\n");
        Console.Write($"{f1.GetTop()}\n");
        Console.Write($"{f1.GetFractionString()}\n");
        Console.Write($"{f1.GetDecimalValue()}\n");
    }
}