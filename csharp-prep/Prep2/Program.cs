using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insert your grade number here: ");
        string grade_t = Console.ReadLine();
        int grade = int.Parse(grade_t);
        string passed = "failed";
        string letter = "F";
        if(grade<60){
            letter = "F";
        }
        else if(grade>=60 && grade<70){
            letter = "D";
            letter = changeSign(grade, letter);
        }
        else if(grade>=70 && grade<80){
            letter = "C";
            passed = "passed";
            letter = changeSign(grade, letter);
        }
        else if(grade>=80 && grade<90){
            letter = "B";
            passed = "passed";
            letter = changeSign(grade, letter);
        }
        else if(grade>=90){
            letter = "A";
            passed = "passed";
            letter = changeSign(grade, letter);
        }
        if(passed == "passed"){
            Console.Write($"Your grade letter is {letter} and you passed the class, congratulations!");
        }
        else{
            Console.Write($"Your grade letter is {letter} and sadly you failed the class, better luck next time.");
        }
    }

    static string changeSign(int grade, string letter){
        if(grade%10 >= 7){
            letter = letter + "+";
        }
        else if(grade%10 <7 && grade%10>3){
            letter = letter;
        }
        else{
            letter = letter + "-";
        }
        return letter;
    }
}