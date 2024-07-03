using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment new_assig = new Assignment("Samuel Bennett", "Multiplication");
        Console.Write($"{new_assig.GetSummary()}");
        MathAssignment new_math = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.Write($"{new_math.GetHomeworkList()}");
        WritingAssignment new_write = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.Write($"{new_write.GetWritingInformation()}");
    }
}