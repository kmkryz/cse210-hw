
public class Journal
{
    // public Journal journal = new Journal();
    public List<Entry> _entries = new List<Entry>();

    //adds entry
    public void AddEntry(Entry _entry)
    {
        _entries.Add(_entry);
    }

    //each entry of journal is displayed
    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        Console.WriteLine();
        foreach (var _entry in _entries)
        {
            Console.WriteLine($"Date: {_entry._date.ToString("yyyy-MM-dd HH:mm:ss")}");
            Console.WriteLine($"Prompt: {_entry.Prompt}");
            Console.WriteLine($"Response: {_entry._response}");
            Console.WriteLine($"Mood: {_entry._mood}");
            Console.WriteLine();
        }
        if (_entries.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("No entries found in the journal.");
        }
    }


    //saves journal to file
    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Date,Prompt,Response");

            foreach (var _entry in _entries)
            {
                writer.WriteLine($"{_entry._date.ToString("yyyy-MM-dd HH:mm:ss")},{_entry.Prompt},{_entry._response},{_entry._mood}");
            }
        }
    }


    //requests filename from user, if invalid follows with exception message
    public void SaveJournal()
    {
        Console.Write("Enter the filename to save the journal (e.g., journal.csv): ");
        string fileName = Console.ReadLine().Trim();

        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Invalid filename. The journal was not saved.");
            return;
        }

        try
        {
            SaveToFile(fileName);
            Console.WriteLine($"Journal saved to {fileName}");
            Console.WriteLine();
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }




    //load from user file, if invalid follows with exception message
    public void LoadJournal(string filePath)
    {
        _entries.Clear(); 

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isFirstLine = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isFirstLine) // Skip the header line
                    {
                        isFirstLine = false;
                        continue;
                    }

                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        DateTime _date = DateTime.Parse(parts[0]);
                        string _prompt = parts[1];
                        string _response = parts[2];
                        string _mood = parts[3];

                        Entry entry = new Entry();
                        entry._date = _date;
                        entry.Prompt = _prompt;
                        entry._response = _response;
                        entry._mood = _mood;

                        _entries.Add(entry);
                    }
                }
         
            }
            Console.WriteLine($"Journal loaded from {filePath}");
            Console.WriteLine();
            DisplayJournal();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}


// +-----------------------------------+
// |              Journal              |
// +-----------------------------------+
// | entries: List<Entry>              |
// +-----------------------------------+
// | AddEntry(entry: Entry)            |
// | DisplayJournal()                  |
// | SaveToCsv(filePath: string)       |
// | SaveJournal()                     |
// | LoadJournal(filePath: string)     |
// +-----------------------------------+