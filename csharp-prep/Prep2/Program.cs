using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();                                                                                        //Spacing
        Console.Write("C# Prep 2");                                                                                 //Writes out Title
        Console.WriteLine();                                                                                        //Spacing
        Console.WriteLine();                                                                                        //Spacing

        Console.Write("What is your grade percentage? ");                                                           //Asks for use input for grade percentage
        string userInput = Console.ReadLine();                                                                      //Returns a string that comes from user input
        int gradePercentage = int.Parse(userInput);                                                                 //Converts user input from string to integer

        string letter = "";                                                                                         //Setting letter variable to blank

        if (gradePercentage >= 90)                                                                                  //Condition for assigning letter grade
        {
            letter = "A";                                                                                           //Assign letter grade based on condition
        }
        else if (gradePercentage >= 80)                                                                             //Condition for assigning letter grade
        {
            letter = "B";                                                                                           //Assign letter grade based on condition
        }
        else if (gradePercentage >= 70)                                                                             //Condition for assigning letter grade
        {
            letter = "C";                                                                                           //Assign letter grade based on condition
        }
        else if (gradePercentage >= 60)                                                                             //Condition for assigning letter grade
        {
            letter = "D";                                                                                           //Assign letter grade based on condition
        }
        else                                                                                                        //Condition for assigning letter grade
        {
            letter = "F";                                                                                           //Assign letter grade based on condition
        }

        int passFail = 0;                                                                                           //Setting passFail variable to 0
        string symbol = "";                                                                                         //Setting symbol variable to blank
        passFail = gradePercentage % 10;                                                                            //Finding the remainder in grade percentage
        
        if (gradePercentage >= 93)                                                                                  //Condition for deciding symbol
        {
            symbol = "";                                                                                            //Change symbol variable to "-"
        }
        else if (gradePercentage < 60)                                                                              //Condition for deciding symbol
        {
            symbol = "";                                                                                            //Change symbol variable to "-"
        }
        else                                                                                                        //Condition for deciding symbol
        {
            if (passFail >= 7)                                                                                      //Condition for deciding symbol
            {
                symbol = "+";                                                                                       //Change symbol variable to "+"
            }
            else if (passFail < 3)                                                                                  //Condition for deciding symbol
            {
                symbol = "-";                                                                                       //Change symbol variable to "-"
            }
            else                                                                                                    //Condition for deciding symbol
            {
                symbol = "";                                                                                        //Change symbol variable to "-"
            }
        }
        
        Console.WriteLine();                                                                                        //Spacing
        Console.WriteLine($"Your letter grade is: {letter}{symbol}");                                               //Returns a string with letter grade and symbol
        
        if (gradePercentage >= 70)                                                                                  //Condition for deciding pass or fail of class
        {
            Console.WriteLine("You passed your class! Way to go!");                                                 //Response for passing class
            Console.WriteLine();                                                                                    //Spacing
        }
        else
        {
            Console.WriteLine("Oof, looks like you failed your class. Better luck next time!");                     //Response for failing class
            Console.WriteLine();                                                                                    //Spacing
        }
    }
}