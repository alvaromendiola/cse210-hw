using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void RunActivity()
    {
        int interval = 4; 
        int cycles = Duration / (interval * 2);

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(interval);
            Console.WriteLine("Breathe out...");
            ShowCountdown(interval);
        }
    }
}
