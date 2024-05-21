using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new Journal object
        Journal journal = new Journal();

        // List of prompts for the journal entries
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool keepGoing = true;
        // Main loop to keep the program running until the user decides to exit
        while (keepGoing)
        {
            // Display the menu options
            Console.WriteLine("Journal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            // Check if the user's input is a valid integer
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        // Write a new journal entry
                        WriteNewEntry(journal, prompts);
                        break;
                    case 2:
                        // Display all journal entries
                        journal.DisplayJournal();
                        break;
                    case 3:
                        // Save the journal entries to a file
                        SaveJournalToFile(journal);
                        break;
                    case 4:
                        // Load journal entries from a file
                        LoadJournalFromFile(journal);
                        break;
                    case 5:
                        // Exit the program
                        keepGoing = false;
                        break;
                    default:
                        // Handle invalid menu option
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
            else
            {
                // Handle invalid input that is not an integer
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine();
        }
    }

    // Method to write a new journal entry
    static void WriteNewEntry(Journal journal, List<string> prompts)
    {
        // Select a random prompt from the list
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");

        // Get the user's response to the prompt
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        // Get the current date and time as a string
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        // Create a new JournalEntry object
        JournalEntry entry = new JournalEntry(prompt, response, date);

        // Add the new entry to the journal
        journal.AddEntry(entry);
        Console.WriteLine("Entry added.");
    }

    // Method to save the journal to a file
    static void SaveJournalToFile(Journal journal)
    {
        // Prompt the user for a filename
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();

        // Save the journal to the specified file
        journal.SaveToFile(filename);
    }

    // Method to load the journal from a file
    static void LoadJournalFromFile(Journal journal)
    {
        // Prompt the user for a filename
        Console.Write("Enter filename to load the journal from: ");
        string filename = Console.ReadLine();

        // Load the journal from the specified file
        journal.LoadFromFile(filename);
    }
}
