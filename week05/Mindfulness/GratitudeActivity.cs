using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base("Gratitude Activity", 
                "This activity will help you focus on gratitude by listing thinds you are thankful for.")
    { }

    public void Run()
    {
        StartMessage();
        int duration = GetDuration();
        int elapsed = 0;
        List<string> gratitudeList = new List<string>();

        Console.WriteLine("Write down things you are grateful for: ");

        while (elapsed < duration)
        {
            string input = Console.ReadLine();
            gratitudeList.Add(input);
            elapsed += 5;
        }

        Console.WriteLine($"You listed {gratitudeList.Count} items of gratitude.");
        EndMessage();
    }
}
    