using System;

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"[{Date}] Prompt: {Prompt}\nResponse: {Response}\n";
    }

    // Method to format entry as a line for saving to file
    public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }
}
