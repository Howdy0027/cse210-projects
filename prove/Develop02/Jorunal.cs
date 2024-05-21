using System; // Importing the System namespace for basic functionalities like Console.
using System.Collections.Generic; // Importing the System.Collections.Generic namespace for using the List class.
using System.IO; // Importing the System.IO namespace for file operations.

public class Journal
{
    // Private field to store the list of journal entries.
    private List<JournalEntry> entries;

    // Constructor to initialize the entries list.
    public Journal()
    {
        entries = new List<JournalEntry>();
    }

    // Method to add a new entry to the journal.
    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    // Method to display all entries in the journal.
    public void DisplayJournal()
    {
        // Loop through each entry and print it.
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    // Method to save all journal entries to a file.
    public void SaveToFile(string filename)
    {
        // Using statement to ensure the StreamWriter is properly disposed of after use.
        using (StreamWriter sw = new StreamWriter(filename))
        {
            // Loop through each entry and write its string representation to the file.
            foreach (var entry in entries)
            {
                sw.WriteLine(entry.ToFileString());
            }
        }
        // Print a message indicating the journal has been saved.
        Console.WriteLine($"Journal saved to {filename}.");
    }

    // Method to load journal entries from a file.
    public void LoadFromFile(string filename)
    {
        // Clear the current entries list.
        entries.Clear();

        // Using statement to ensure the StreamReader is properly disposed of after use.
        using (StreamReader sr = new StreamReader(filename))
        {
            string line;
            // Read each line from the file until the end of the file is reached.
            while ((line = sr.ReadLine()) != null)
            {
                // Split the line into parts based on the '|' character.
                var parts = line.Split('|');
                // Check if the line has the correct number of parts.
                if (parts.Length == 3)
                {
                    // Create a new JournalEntry from the parts and add it to the entries list.
                    JournalEntry entry = new JournalEntry(parts[1], parts[2], parts[0]);
                    entries.Add(entry);
                }
            }
        }
        // Print a message indicating the journal has been loaded.
        Console.WriteLine($"Journal loaded from {filename}.");
    }
}

// Note: The JournalEntry class is assumed to be defined elsewhere in the project with appropriate properties and methods, including a ToFileString method.
