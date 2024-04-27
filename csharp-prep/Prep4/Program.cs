using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();                                                                                        //Spacing
        Console.Write("C# Prep 4");                                                                                 //Writes out Title
        Console.WriteLine();                                                                                        //Spacing
        Console.WriteLine();                                                                                        //Spacing

        Console.Write("Enter a list of numbers, type 0 when finished.");                                            //Writes out instructions
        Console.WriteLine();                                                                                        //Spacing

        List<int> numbers = new List<int>();                                                                        //Setting list to be a new (blank) list
        
        int userNumber = -1;                                                                                        //Setting userNumber to be -1
        while (userNumber != 0)                                                                                     //While loop for creating asking for user input of numbers
        {
            Console.Write("Enter number: ");                                                                        //Ask for user input for number to add to list
            
            string userResponse = Console.ReadLine();                                                               //Convert number to string
            userNumber = int.Parse(userResponse);                                                                   //Convert number to integer
            
            if (userNumber != 0)                                                                                    //If user input equals 0, add numbers together
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)                                                                             //For loop for creating sum number
        {
            sum += number;                                                                                          //Adds sum to new number
        }

        Console.WriteLine();                                                                                        //Spacing
        Console.WriteLine($"The sum is: {sum}");                                                                    //Returns a string with sum number

        float averageNumber = ((float)sum) / numbers.Count;                                                         //Converts string to float number
        Console.WriteLine($"The average number is: {averageNumber}");                                               //Returns a string with average number

        int maxNumber = numbers[0];

        foreach (int number in numbers)                                                                             //For loop for searching list for max number
        {
            if (number > maxNumber)
            {
                maxNumber = number;                                                                                 //If number is max then rename
            }
        }

        Console.WriteLine($"The max is: {maxNumber}");                                                              //Returns a string with max number
        Console.WriteLine();                                                                                        //Spacing
    }
}