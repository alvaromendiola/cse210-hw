using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> Prompts { get; set; }

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);

        Console.WriteLine("Start listing items:");

        int startTime = Environment.TickCount;
        List<string> items = new List<string>();
        while (Environment.TickCount - startTime < Duration * 1000)
        {
            Console.Write("- ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}
