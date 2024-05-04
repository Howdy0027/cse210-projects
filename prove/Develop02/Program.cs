using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool keepGoing = true;
        while (keepGoing)
        {
            Console.WriteLine("Journal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
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

    static void WriteNewEntry(Journal journal, List<string> prompts)
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        JournalEntry entry = new JournalEntry(prompt, response, date);
        journal.AddEntry(entry);
        Console.WriteLine("Entry added.");
    }

    static void SaveJournalToFile(Journal journal)
    {
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void LoadJournalFromFile(Journal journal)
    {
        Console.Write("Enter filename to load the journal from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}
