using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert your name: ");
        string name = Console.ReadLine();
        User u = new User(name);
        u.ShowPrompt();
    }
}