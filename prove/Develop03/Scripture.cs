using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = 3; 

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(Words.Count);
            Words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (var word in Words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }

    public override string ToString()
    {
        string scriptureText = string.Join(" ", Words);
        return $"{Reference}\n{scriptureText}";
    }
}
