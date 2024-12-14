using System;

public class ChecklistGoal : Goal
{
    private int TargetCount { get; set; }
    private int CurrentCount { get; set; }
    private int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount >= TargetCount)
        {
            IsCompleted = true;
        }
    }

    public override string GetProgress()
    {
        return $"Completed {CurrentCount}/{TargetCount} times";
    }

    public override string GetGoalType()
    {
        return "Checklist Goal";
    }

    public int GetBonusPoints()
    {
        return IsCompleted ? BonusPoints : 0;
    }
}
