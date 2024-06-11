using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insert your first name here: ");
        string f_name = Console.ReadLine();
        Console.Write("Insert your last name here: ");
        string l_name = Console.ReadLine();
        Console.WriteLine($"Your name is {l_name}, {f_name} {l_name}");
    }
}