using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal

{
    private const string Value = "...................";
    public List<Entry> _entries = new List<Entry>();
    private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
    {
        IncludeFields = true,
        WriteIndented = true
    };

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {

            entry.Display();
            Console.WriteLine(Value);
        }
    }

    public void SaveToFile(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("A file name is required.");
            return;
        }

        File.WriteAllText(fileName, JsonSerializer.Serialize(_entries, JsonOptions));
        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("A file name is required.");
            return;
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(
            File.ReadAllText(fileName), JsonOptions) ?? new List<Entry>();
        _entries = loadedEntries;
        Console.WriteLine("Journal loaded.");
    }
}
