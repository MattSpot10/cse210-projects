using System.Text.RegularExpressions;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void SaveJournal(string filename)
    {
        string suffix = filename.Split('.').Last();

        if (suffix != "txt" && suffix != "csv")
        {
            Console.WriteLine("Invate file name extension. Please use only .txt or .csv");
            return;
        }
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString(suffix));
            }
        }
    }
    public void LoadJournal(string filename)
    {

        if (filename.EndsWith(".txt"))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("#");
                string date = parts[0];
                string question = parts[1];
                string entryText = parts[2];

                Entry entry = new Entry(date, question, entryText);
                this.AddEntry(entry);
            }
            return;
        }
        if (filename.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                MatchCollection matches = Regex.Matches(line, "\"(.*?)\"");//matches the text between the double quotes.

                string date = matches[0].Groups[1].Value;
                string question = matches[1].Groups[1].Value;
                string entryText = matches[2].Groups[1].Value;

                Entry entry = new Entry(date, question, entryText);
                this.AddEntry(entry);
            }
            return;
        }
        Console.WriteLine("Invate file name extension. Please use only .txt or .csv");
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}