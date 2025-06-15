
class ReflectingActivity : Activity
{
    private readonly string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private readonly string[] _followups =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity() :
    base("Reflection Activity",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    )
    {

    }
    public void RunReflectingActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.Clear();

        Random random = new Random();
        int randomPrompt = random.Next(0, _prompts.Count());

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n--- {_prompts[randomPrompt]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Counter(5);
        Console.Clear();

        List<int> questionsIndexs = Enumerable.Range(0, _followups.Count()).ToList();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _time)
        {
            int randomIndex = random.Next(0, questionsIndexs.Count());

            Console.Write($"> {_followups[questionsIndexs[randomIndex]]} ");
            questionsIndexs.RemoveAt(randomIndex);
            if (questionsIndexs.Count() == 0)
            {
                questionsIndexs = Enumerable.Range(0, _followups.Count()).ToList();
            }
            Spinner(6);
            Console.WriteLine();
        }
        DisplayEndMessage();
    }
}