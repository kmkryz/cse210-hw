
public class Journal
{
    private List<Entry> entries = new List<Entry>();

    //adds entry
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    //each entry of journal is displayed
    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry._date.ToString("yyyy-MM-dd HH:mm:ss")}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine($"Mood: {entry._mood}");
            Console.WriteLine();
        }
    }


    //saves journal to csv journal.csv
    public void SaveToCsv(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Date,Prompt,Response");

            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry._date.ToString("yyyy-MM-dd HH:mm:ss")},{entry._prompt},{entry._response}");
            }
        }
    }


    //save to user file
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
            SaveToCsv(fileName);
            Console.WriteLine($"Journal saved to {fileName}");
        }
                catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }




    //load from user file
    public void LoadJournal(string filePath)
    {
        entries.Clear(); 

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
                    if (parts.Length == 3)
                    {
                        DateTime _date = DateTime.Parse(parts[0]);
                        string _prompt = parts[1];
                        string _response = parts[2];
                        string _mood = parts[3];

                        Entry entry = new Entry();
                        entry._date = DateTime.Now;
                        entry._prompt = _prompt;
                        entry._response = _response;
                        entry._mood = _mood;

                        entries.Add(entry);
                    }
                }
         
            }
            Console.WriteLine($"Journal loaded from {filePath}");
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