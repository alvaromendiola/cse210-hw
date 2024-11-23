using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Moses", 5, 9), "And in that day the Holy Ghost fell upon Adam, which beareth record of the Father and the Son, saying: I am the Only Begotten of the Father from the beginning, henceforth and forever, that as thou hast fallen thou mayest be redeemed, and all mankind, even as many as will."),
            new Scripture(new Reference("Proverbs", 29, 18), "Where there is no vision, the people perish: but he that keepeth the law, happy is he."),
            new Scripture(new Reference("Mosiah", 5, 2), "And they all cried with one voice, saying: Yea, we believe all the words which thou hast spoken unto us; and also, we know of their surety and truth, because of the Spirit of the Lord Omnipotent, which has wrought a mighty change in us, or in our hearts, that we have no more disposition to do evil, but to do good continually."),
            new Scripture(new Reference("Jacob", 7, 12), "And this is not all—it has been made manifest unto me, for I have heard and seen; and it also has been made manifest unto me by the power of the Holy Ghost; wherefore, I know if there should be no atonement made all mankind must be lost."),
            new Scripture(new Reference("Nehemiah", 9, 20), "Thou gavest also thy good spirit to instruct them, and withheldest not thy manna from their mouth, and gavest them water for their thirst.")
        };

        Random random = new Random();

        while (true)
        {
            Scripture scripture = scriptures[random.Next(scriptures.Count)];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to select a new scripture or exit.");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                if (scripture.AllWordsHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture);
                    Console.WriteLine("\nAll words are hidden. Program will exit now.");
                    return;
                }

                scripture.HideRandomWords();
            }

            if (scripture.AllWordsHidden())
            {
                return;
            }
        }
    }
}
