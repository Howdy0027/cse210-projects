using System;

public class JournalEntry
{
    // Properties to store the prompt, response, and date of the journal entry
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    // Constructor to initialize a new journal entry with the provided prompt, response, and date
    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // Override the ToString method to return a formatted string representation of the journal entry
    public override string ToString()
    {
        return $"[{Date}] Prompt: {Prompt}\nResponse: {Response}\n";
    }

    // Method to format the journal entry as a line for saving to a file
    public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }
}

