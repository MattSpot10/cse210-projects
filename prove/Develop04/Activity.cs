class Activity
{
    private string _name;
    private string _description;
    protected int _time;
    private readonly char[] spinner = { '\\', '|', '/', '-' };

    public Activity(string name, string description, int time)
    {
        _name = name;
        _description = description;
        _time = time;
    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);

        Console.WriteLine("How many seconds would you like to do this activity?");
        string input = Console.ReadLine();

        int time = 0;
        while (!int.TryParse(input, out time))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            input = Console.ReadLine();
        }
        _time = time;
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        Spinner(3);
        Console.WriteLine($"You have completed another {_time} seconds of the {_name}");
        Spinner(3);

    }
    public void Spinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        int count = 0;
        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write(spinner[count % 4]);
            count++;
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.Write(" ");
        Console.Write("\b");
    }
    public void Counter(int seconds)
    {
        DateTime startTime = DateTime.Now;
        int count = seconds;
        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write(count);
            count--;
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write(" ");
        Console.Write("\b");
    }
}