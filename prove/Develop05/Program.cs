using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu option");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option from the menu: ");
            string choice = Console.ReadLine();

            Activity activity;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activity.Start();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    activity.Start();
                    break;
                case "3":
                    activity = new ListingActivity();
                    activity.Start();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey();
            }
        }
    }
}
