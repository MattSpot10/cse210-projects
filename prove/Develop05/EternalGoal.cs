class EternalGoal : Goal
{
    int _timesCompleted = 0;
    public EternalGoal() : base()
    {

    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()} -- times completed: {_timesCompleted} times");
    }
    public override bool RecordEvent() // returns if the event was recorded successfuly
    {
        _timesCompleted++;
        return true;
    }
    public override string ToSaveString()
    {
        return $"E#{GetName()}#{GetDescription()}#{GetPointValue()}#{_timesCompleted}";
    }
    public override void FromSaveString(string str)
    {
        string[] parts = str.Split("#");
        SetName(parts[1]);
        SetDescription(parts[2]);
        SetPointValue(int.Parse(parts[3]));
        _timesCompleted = int.Parse(parts[4]);
    }
    public override void PopulateGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        SetName(Console.ReadLine());
        Console.WriteLine("What is a short description of it?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal?");
        SetPointValue(HelperFunctions.GetUserNumber());
    }

}