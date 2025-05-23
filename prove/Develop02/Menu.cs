class Menu
{
    private bool _quit = false;
    private readonly List<string> _selections = new List<string>
    {
        "Write a new entry",
        "Display the journal",
        "Load journal from file",
        "Save jounral to file",
        "Quit"
    };
    public void ProcessMenu(Journal myJournal)
    {
        for (int i = 0; i < _selections.Count; i++)
        {
            Console.WriteLine($"{i + 1} {_selections[i]}");
        }

        string selection = Console.ReadLine();

        switch (selection)
        {
            case "1":
                Entry entry = new Entry();
                entry.CreateEntry();
                myJournal.AddEntry(entry);
                break;
            case "2":
                myJournal.DisplayJournal();
                break;
            case "3":
                Console.WriteLine("Enter filename: Use [name].txt or [name].csv extension");
                string filename = Console.ReadLine();
                myJournal.LoadJournal(filename);
                break;
            case "4":
                Console.WriteLine("Enter filename: Use [name].txt or [name].csv extension");
                filename = Console.ReadLine();
                myJournal.SaveJournal(filename);
                break;
            case "5":
                _quit = true;
                break;
        }

    }
    public bool Quit()
    {
        return _quit;
    }
}