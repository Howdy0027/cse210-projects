using System;

public class Program
{
    public static void Main()
    {
        // Initialize the scripture reference and text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        // Main loop: Continues until the user quits or all words are hidden
        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine(scripture.GetDisplayText()); // Display the scripture text
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine(); // Get user input
            if (input.ToLower() == "quit")
            {
                break; // Exit the loop if the user types 'quit'
            }

            scripture.HideRandomWords(3); // Hide a few random words

            // If all words are hidden, display the final message and exit
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program will now exit.");
                break;
            }
        }
    }
}
