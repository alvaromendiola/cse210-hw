using System;

public abstract class Activity
{
    private DateTime Date { get; set; }
    private int LengthInMinutes { get; set; }

    public Activity(DateTime date, int lengthInMinutes)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({LengthInMinutes} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }

    protected int GetLengthInMinutes()
    {
        return LengthInMinutes;
    }
}
