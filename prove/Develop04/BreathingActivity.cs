class BreathingActivity : Activity
{
    public BreathingActivity() :
    base("Breathing Activity",
    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public void RunBreathingActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _time)
        {
            Console.WriteLine("\nBreathe in...");
            Counter(4);
            Console.WriteLine("Now breathe out...");
            Counter(6);
        }
        DisplayEndMessage();

    }
}