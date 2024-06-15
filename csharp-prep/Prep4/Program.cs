using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> ListOfNumbers = new List<int>();
        int number=10;
        do{
            Console.Write("Insert the number you want to add to the list: ");
            string s_number = Console.ReadLine();
            number = int.Parse(s_number);
            if(number!=0){
                ListOfNumbers.Add(number);
            }
        }while(number!=0);
        int sum = 0;
        int largest = 0;
        int smallest_p = 1000000000;
        for(int i=0; i<ListOfNumbers.Count; i++){
            sum += ListOfNumbers[i];
            Console.Write($"{ListOfNumbers[i]} ");
            if(ListOfNumbers[i]>largest){
                largest = ListOfNumbers[i];
            }
            if(ListOfNumbers[i]<smallest_p && ListOfNumbers[i]>0){
                smallest_p = ListOfNumbers[i];
            }
        }
        double average = (double)sum/(double)ListOfNumbers.Count();
        Console.Write($"The largest number in your list is: {largest}\n");
        Console.Write($"The sum of elements of your list is: {sum}\n");
        Console.Write($"The average of elements of your list is: {average}\n");
        Console.Write($"The smallest positive number of your list is: {smallest_p}");
    }
}