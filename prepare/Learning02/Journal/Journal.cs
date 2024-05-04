using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries;

    public Journal()
    {
        entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                sw.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine($"Journal saved to {filename}.");
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader sr = new StreamReader(filename))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    JournalEntry entry = new JournalEntry(parts[1], parts[2], parts[0]);
                    entries.Add(entry);
                }
            }
        }
        Console.WriteLine($"Journal loaded from {filename}.");
    }
}
