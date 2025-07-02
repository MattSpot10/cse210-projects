using System.Collections;

class Goals
{
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void ListGoals()
    {
        Console.WriteLine("Your goals are:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.Write($"{i + 1}: ");
            _goals[i].DisplayGoal();
        }
    }
    public int RecordEvent()
    {
        ListGoals();
        Console.WriteLine("Which goal did you accomplish?");
        int selection = HelperFunctions.GetUserSelection(1, _goals.Count());
        if (_goals[selection - 1].RecordEvent())
        {
            return _goals[selection - 1].GetPointValue();
        }
        return 0;
    }
    public int LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        int totalPoints = int.Parse(lines[0]);
        foreach (string line in lines[1..])
        {
            switch (line[0])
            {
                case 'S':
                    SimpleGoal mySimpleGoal = new SimpleGoal();
                    mySimpleGoal.FromSaveString(line);
                    _goals.Add(mySimpleGoal);
                    break;
                case 'E':
                    EternalGoal myEternalGoal = new EternalGoal();
                    myEternalGoal.FromSaveString(line);
                    _goals.Add(myEternalGoal);
                    break;
                case 'C':
                    ChecklistGoal myChecklistGoal = new ChecklistGoal();
                    myChecklistGoal.FromSaveString(line);
                    _goals.Add(myChecklistGoal);
                    break;
            }
        }
        return totalPoints;

    }
    public void SaveGoals(string filename, int totalPoints)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(totalPoints);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.ToSaveString());
            }
        }
    }

}