using System;

class Program
{
    
    static void Main(string[] args)                                                                                 //Main function
    {
        DisplayWelcomeMessage();                                                                                    //Run first function

        string userName = PromptUserName();                                                                         //Run second function
        int userNumber = PromptUserNumber();                                                                        //Run third function

        int squaredNumber = SquareNumber(userNumber);                                                               //Run fourth function

        DisplayResult(userName, squaredNumber);                                                                     //Run fifth function
    }

    static void DisplayWelcomeMessage()                                                                             //First function (Title and welcome message)
    {
        Console.WriteLine();                                                                                        //Spacing
        Console.Write("C# Prep 5");                                                                                 //Writes out Title
        Console.WriteLine();                                                                                        //Spacing
        Console.WriteLine();                                                                                        //Spacing
        
        Console.WriteLine("Welcome to the program!");                                                               //Writes out welcome message
        Console.WriteLine();                                                                                        //Spacing
    }

    static string PromptUserName()                                                                                  //Second function (user input for userName)
    {
        Console.Write("Please enter your name: ");                                                                  //Asks for user input for user name
        string name = Console.ReadLine();                                                                           //Converts user name to string

        return name;                                                                                                //Returns function variable for name
    }

    static int PromptUserNumber()                                                                                   //Third function (user input for userNumber)
    {
        Console.Write("Please enter your favorite number: ");                                                       //Asks for user input for favorite number
        int number = int.Parse(Console.ReadLine());                                                                 //Converts user number to integer

        return number;                                                                                              //Returns function variable for number
    }

    static int SquareNumber(int number)                                                                             //Fourth function (square userNumber)
    {
        int square = number * number;                                                                               //Math equation for squaring userNumber
        return square;                                                                                              //Returns function variable for square number
    }

    static void DisplayResult(string name, int square)                                                              //Fifth function (response with inputs)
    {
        Console.WriteLine();                                                                                        //Spacing
        Console.WriteLine($"{name}, the square of your number is {square}");                                        //Returns response with inputs
        Console.WriteLine();                                                                                        //Spacing
    }
}