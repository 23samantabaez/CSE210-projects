public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
    }

    public void AddEntry(string promptText) //adds a new journal entry, prompting the user for inputs
    {
        Entry newEntry = new Entry();
        DateTime theCurrentTime = DateTime.Now; //Gets the current date and time for the entry
        newEntry._date = theCurrentTime.ToShortDateString();
        newEntry._prompt = promptText;
        Console.WriteLine($"Prompt: {newEntry._prompt}");
        Console.WriteLine("Type your entry: ");
        newEntry._content = Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void LoadEntries(string fileName)
    {
        _entries.Clear(); //starts with a fresh list of entries
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] parts = line.Split("|");
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._content = parts[2];
            _entries.Add(newEntry); //adds journal entry to the journal object
        }
    }

    public void SaveEntries(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e.StringForFile()); //writes each lne based on the method in the Entry class
            }
        }
    }

    public void DisplayEntries()
    {
        Console.WriteLine();
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no journal entries to display");
        }

        else
        {
            Console.WriteLine("These are your journal entries: ");
            foreach (Entry e in _entries) //loops through all entries in the journal
            {
                e.Display(); //uses the method in the Entry class to display the entries
            }
        }
    }
    
}