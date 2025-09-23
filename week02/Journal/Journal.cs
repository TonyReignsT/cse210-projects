using System;
using System.Collections.Generic;

public class Journal
{
    // A list to store multiple entries
    public List<Entry> _entries = new List<Entry>();

    // Add a new entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display(); // Call each entry's Display method
        }
    }

    // Save entries to a file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // Save as a single line: date|prompt|entry
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
    }

    // Load entries from a file
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._entry = parts[2];

            _entries.Add(newEntry);
        }
    }
}