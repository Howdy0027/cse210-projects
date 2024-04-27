using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();                                                                //Spacing
        Console.Write("C# Prep 1");                                                         //Writes out Title
        Console.WriteLine();                                                                //Spacing
        Console.WriteLine();                                                                //Spacing

        Console.Write("What is your first name? ");                                         //Asks for use input for first name
        string fname = Console.ReadLine();                                                  //Returns a string that comes from user input

        Console.Write("What is your last name? ");                                          //Asks for use input for last name
        string lname = Console.ReadLine();                                                  //Returns a string that comes from user input

        Console.WriteLine();                                                                //Spacing
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");                       //Returns a string with user input
        Console.WriteLine();                                                                //Spacing
    }
}