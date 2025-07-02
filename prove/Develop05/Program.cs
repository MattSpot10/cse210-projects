using System;

class Program
{
    static void Main(string[] args)
    {

        Goals myGoals = new Goals();
        int _totalPoints = 0;
        while (true)
        {
            Console.WriteLine($"\nYou have {_totalPoints} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\n");


            int selection = HelperFunctions.GetUserSelection(1, 6);
            switch (selection)
            {
                case 1://Create New Goal
                    Console.WriteLine("Which type of goal would you like to create?");
                    Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                    int goalOption = HelperFunctions.GetUserSelection(1, 3);
                    switch (goalOption)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.PopulateGoal();
                            myGoals.AddGoal(simpleGoal);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.PopulateGoal();
                            myGoals.AddGoal(eternalGoal);
                            break;
                        case 3:
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.PopulateGoal();
                            myGoals.AddGoal(checklistGoal);
                            break;
                    }
                    break;
                case 2://List Goals
                    myGoals.ListGoals();
                    break;
                case 3://Save Goals
                    Console.WriteLine("What is the filename?");
                    myGoals.SaveGoals(Console.ReadLine(), _totalPoints);
                    break;
                case 4://Load Goals
                    Console.WriteLine("What is the filename?");
                    _totalPoints += myGoals.LoadGoals(Console.ReadLine());
                    break;
                case 5://Record Event
                    _totalPoints += myGoals.RecordEvent();
                    break;
                case 6://Quit
                    return;
                default:
                    break;
            }
        }
    }
}