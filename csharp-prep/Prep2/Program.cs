using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            if (percent >= 93)
                letter = "A";
            else
                letter = "A-";
        }
        else if (percent >= 80)
        {
            if (percent >= 87)
                letter = "B+";
            else if (percent >= 83)
                letter = "B";
            else
                letter = "B-";
        }
        else if (percent >= 70)
        {
            if (percent >= 77)
                letter = "C+";
            else if (percent >= 73)
                letter = "C";
            else
                letter = "C-";
        }
        else if (percent >= 60)
        {
            if (percent >= 67)
                letter = "D+";
            else if (percent >= 63)
                letter = "D";
            else
                letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}