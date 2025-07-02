class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _timesToComplete = 0;
    public ChecklistGoal() : base()
    {

    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(GetIsComplete() ? 'X' : ' ')}] {GetName()} ({GetDescription()}) -- Currently Completed: {_timesCompleted}/{_timesToComplete}");
    }
    public override bool RecordEvent() // returns if the event was recorded successfuly
    {
        if (_timesCompleted < _timesToComplete)
        {
            _timesCompleted++;
            if (_timesCompleted == _timesToComplete)
            {
                SetIsComplete(true);
            }
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string ToSaveString()
    {
        return $"C#{GetName()}#{GetDescription()}#{GetPointValue()}#{_timesCompleted}#{_timesToComplete}";
    }
    public override void FromSaveString(string str)
    {
        string[] parts = str.Split("#");
        SetName(parts[1]);
        SetDescription(parts[2]);
        SetPointValue(int.Parse(parts[3]));

        _timesCompleted = int.Parse(parts[4]);
        _timesToComplete = int.Parse(parts[5]);
    }
    public override void PopulateGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        SetName(Console.ReadLine());
        Console.WriteLine("What is a short description of it?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal?");
        SetPointValue(HelperFunctions.GetUserNumber());
        Console.WriteLine("How many times does this goal need to be completed?");
        _timesToComplete = HelperFunctions.GetUserNumber();
    }

}