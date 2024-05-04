using System;
using System.Collections.Generic;

class JournalProgram
{
    // Entry point of the program
    static void RunJournalProgram()
    {
        // Create a new Journal instance
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
        
        // Flag to control the program loop
        bool keepGoing = true;
        
        // Main loop for the program
        while (keepGoing)
        {
            // Display menu options to the user
            Console.WriteLine("Journal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            
            // Get user choice
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                // Handle user choice
                switch (choice)
                {
                    case 1:
                        WriteNewEntry(journal, prompts);
                        break;
                    case 2:
                        journal.DisplayJournal();
                        break;
                    case 3:
                        SaveJournalToFile(journal);
                        break;
                    case 4:
                        LoadJournalFromFile(journal);
                        break;
                    case 5:
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine();
        }
    }

    // Method to write a new entry to the journal
    static void WriteNewEntry(Journal journal, List<string> prompts)
    {
        // Randomly select a prompt from the list
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        
        // Display the prompt and get the user's response
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        
        // Get the current date and time
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        
        // Create a new JournalEntry with the prompt, response, and date
        JournalEntry entry = new JournalEntry(prompt, response, date);
        
        // Add the entry to the journal
        journal.AddEntry(entry);
        
        // Inform the user that the entry has been added
        Console.WriteLine("Entry added.");
    }

    // Method to save the journal to a file
    static void SaveJournalToFile(Journal journal)
    {
        // Prompt the user for a filename
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();
        
        // Save the journal to the file
        journal.SaveToFile(filename);
    }

    // Method to load the journal from a file
    static void LoadJournalFromFile(Journal journal)
    {
        // Prompt the user for a filename
        Console.Write("Enter filename to load the journal from: ");
        string filename = Console.ReadLine();
        
        // Load the journal from the file
        journal.LoadFromFile(filename);
    }
}

// At the end of the file, include the following line to start the program
// when the application runs:
JournalProgram.RunJournalProgram();
