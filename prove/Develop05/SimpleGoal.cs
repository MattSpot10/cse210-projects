class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {

    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(GetIsComplete() ? 'X' : ' ')}] {GetName()} ({GetDescription()}");
    }
    public override bool RecordEvent() // returns if the event was recorded successfuly
    {
        if (!GetIsComplete())
        {
            SetIsComplete(true);
            return true;
        }
        return false;
    }
    public override string ToSaveString()
    {
        return $"S#{GetName()}#{GetDescription()}#{GetPointValue()}#{GetIsComplete()}";
    }
    public override void FromSaveString(string str)
    {
        string[] parts = str.Split("#");
        SetName(parts[1]);
        SetDescription(parts[2]);
        SetPointValue(int.Parse(parts[3]));
        SetIsComplete(Boolean.Parse(parts[4]));
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