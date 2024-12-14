using System;
using System.Collections.Generic;

public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int totalPoints = 0;

    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals and progress");
            Console.WriteLine("4. Show total points");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    ShowPoints();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            case "4":
                goals.Add(new NegativeGoal(name, points));
                break;
            default:
                Console.WriteLine("Invalid option. Goal not created.");
                break;
        }
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }
        int goalChoice = int.Parse(Console.ReadLine()) - 1;

        if (goalChoice >= 0 && goalChoice < goals.Count)
        {
            goals[goalChoice].RecordEvent();

            if (goals[goalChoice] is NegativeGoal negativeGoal)
            {
                totalPoints += negativeGoal.GetNegativePoints();
            }
            else
            {
                totalPoints += goals[goalChoice].GetPoints();
                
                if (goals[goalChoice] is ChecklistGoal checklistGoal && checklistGoal.GetProgress().StartsWith("Completed"))
                {
                    totalPoints += checklistGoal.GetBonusPoints();
                }
            }

            Console.WriteLine("Event recorded!");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    private static void ShowGoals()
    {
        Console.WriteLine("Goals and Progress:");
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal} - {goal.GetProgress()}");
        }
        Console.ReadLine(); 
    }

    private static void ShowPoints()
    {
        Console.WriteLine($"Total Points: {totalPoints}");
        Console.ReadLine(); 
    }

    private static void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(totalPoints);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetGoalType());
                writer.WriteLine(goal);
            }
        }
        Console.WriteLine("Goals saved!");
        Console.ReadLine(); 
    }

    private static void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                totalPoints = int.Parse(reader.ReadLine());

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string goalType = line;
                    string goalDetails = reader.ReadLine();
                    string[] details = goalDetails.Split('-');

                    string name = details[0].Trim();
                    int points = int.Parse(details[1].Trim().Split(' ')[0]);

                    switch (goalType)
                    {
                        case "Simple Goal":
                            goals.Add(new SimpleGoal(name, points));
                            break;
                        case "Eternal Goal":
                            goals.Add(new EternalGoal(name, points));
                            break;
                        case "Checklist Goal":
                            int targetCount = int.Parse(details[1].Trim().Split(' ')[0]);
                            int bonusPoints = int.Parse(details[2].Trim().Split(' ')[0]);
                            goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                            break;
                        case "Negative Goal":
                            goals.Add(new NegativeGoal(name, points));
                            break;
                        default:
                            Console.WriteLine("Unknown goal type. Skipping...");
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        Console.ReadLine(); 
    }
}
