using System;

public abstract class Goal
{
    private string Name { get; set; }
    private int Points { get; set; }
    protected bool IsCompleted { get; set; }  

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract string GetProgress();
    public abstract string GetGoalType();

    public int GetPoints()
    {
        return Points;
    }

    public override string ToString()
    {
        return $"{(IsCompleted ? "[X]" : "[ ]")} {Name} - {Points} points";
    }
}

