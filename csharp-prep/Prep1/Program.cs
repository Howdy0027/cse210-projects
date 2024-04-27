using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();                                                                //Spacing
        Console.Write("C# Prep 1");                                                         //Writes out Title
        Console.WriteLine();                                                                //Spacing
        Console.WriteLine();                                                                //Spacing

        Console.Write("What is your first name? ");                                         //Input for first name
        string fname = Console.ReadLine();                                                  //Returns a string that comes from users input

        Console.Write("What is your last name? ");                                          //Input for last name
        string lname = Console.ReadLine();                                                  //Returns a string that comes from users input

        Console.WriteLine();                                                                //Spacing
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");                       //Returns a string with users input
        Console.WriteLine();                                                                //Spacing
    }
}