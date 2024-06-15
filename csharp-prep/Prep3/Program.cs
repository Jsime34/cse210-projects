using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(1, 101);
        int numberOfTries = 0;
        bool found = false;
        do{
            Console.Write("Guess the number!(1-100)\n");
            numberOfTries++;
            Console.Write("Insert your guess here: ");
            string numberS = Console.ReadLine();
            int number = int.Parse(numberS);
            if(number > randNumber){
                Console.Write("The number is a lower than the one you just gave.");
            }
            else if(number < randNumber){
                Console.Write("The number is higher than the one you just gave.");
            }
            else{
                Console.Write("You found the number!, GG Well Played\n");
                Console.Write($"Number of tries: {numberOfTries}");
                found=true;
            }
        }while(found==false);
    }
}