using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        
        IsCompleted = true;
    }

    public override string GetProgress()
    {
        return IsCompleted ? "Negative Event Recorded" : "Not Recorded";
    }

    public override string GetGoalType()
    {
        return "Negative Goal";
    }

    public int GetNegativePoints()
    {
        return -GetPoints(); 
    }
}
