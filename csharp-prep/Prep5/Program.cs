using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number_f = PromptUserNumber();
        int number_s = SquareNumber(number_f);
        DisplayResult(number_s, name);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("Insert your name here, please: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.Write("Insert your favorite number here: ");
        string s_num = Console.ReadLine();
        int num = int.Parse(s_num);
        return num;
    }
    static int SquareNumber(int number){
        int s_num = number*number;
        return s_num;
    }
    static void DisplayResult(int number, string name){
        Console.Write($"Dear {name}, your squared number is {number}");
    }
}