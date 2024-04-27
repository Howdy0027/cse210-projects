using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();                                                                                        //Spacing
        Console.Write("C# Prep 3");                                                                                 //Writes out Title
        Console.WriteLine();                                                                                        //Spacing
        Console.WriteLine();                                                                                        //Spacing

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);                                                             //Creates magicNumber to be a random integer between 1 and 100

        int userGuess = -1;                                                                                         //Setting userGuess variable to -1

        while (userGuess != magicNumber)                                                                            //Creating while loop
        {
            Console.Write("What do you think the magic number is? ");                                               //Asks for user inout to guess magic number
            userGuess = int.Parse(Console.ReadLine());                                                              //Converts user input from string to integer

            if (magicNumber > userGuess)                                                                            //Condition for if guess is too high
            {
                Console.WriteLine("The Magic Number is HIGHER than this.");                                         //Response for too high guess
                Console.WriteLine();                                                                                //Spacing
            }
            else if (magicNumber < userGuess)                                                                       //Condition for if guess is too low
            {
                Console.WriteLine("The Magic Number is LOWER than this.");                                          //Response for too low guess
                Console.WriteLine();                                                                                //Spacing
            }
            else                                                                                                    //Condition for if guess is correct
            {
                Console.WriteLine("Yay!! You guessed it, Bravo!!");                                                 //Response for correct guess
                Console.WriteLine();                                                                                //Spacing
            }
        }                    
    }
}