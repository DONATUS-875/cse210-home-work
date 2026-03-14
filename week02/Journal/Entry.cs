using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public void Display()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Word Count: {WordCount()}");
        Console.WriteLine("--------------------------------");
    }

    public int WordCount()
    {
        string[] words = _entryText.Split("",StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}