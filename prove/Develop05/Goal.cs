using System.Dynamic;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal()
    {

    }
    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public abstract bool RecordEvent();
    public abstract void DisplayGoal();
    public abstract string ToSaveString();
    public abstract void FromSaveString(string str);

    public abstract void PopulateGoal();

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPointValue()
    {
        return _points;
    }
    public void SetPointValue(int points)
    {
        _points = points;
    }
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

}