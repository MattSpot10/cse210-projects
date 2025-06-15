class ListingActivity : Activity
{
    private readonly string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() :
    base("Listing Activity",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    public void RunListingActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);

        Random random = new Random();
        int randomPrompt = random.Next(0, _prompts.Count());

        Console.WriteLine("List as many responses you can for the following prompt:");
        Console.WriteLine($"\n--- {_prompts[randomPrompt]} ---\n");
        Console.Write("You may begin in: ");
        Counter(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;

        int counter = 0;
        while ((DateTime.Now - startTime).TotalSeconds < _time)
        {
            Console.Write("> ");
            Console.ReadLine();
            counter++;
        }
        Console.WriteLine($"\nYou listen {counter} items!");
        DisplayEndMessage();

    }

}