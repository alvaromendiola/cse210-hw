using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        IsCompleted = true;
    }

    public override string GetProgress()
    {
        return IsCompleted ? "Completed" : "Not Completed";
    }

    public override string GetGoalType()
    {
        return "Simple Goal";
    }
}
