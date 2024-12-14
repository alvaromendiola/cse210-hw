using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        
    }

    public override string GetProgress()
    {
        return "Eternal Goal - Ongoing";
    }

    public override string GetGoalType()
    {
        return "Eternal Goal";
    }
}
