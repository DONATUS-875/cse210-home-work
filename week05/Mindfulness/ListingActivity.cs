using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{
    public ListingActivity()
        : base("Listing Activity",
                "This activity will help you think broadly by listing positive things in your life.")
    { }

    public void Run()
    {
        StartMessage();
        int duration = GetDuration();
        int elapsed = 0;
        List<string> items = new List<string>();

        Console.WriteLine("List as many strengths as you can:");

        while (elapsed < duration)
        {
                string input = Console.ReadLine();
                items.Add(input);
                elapsed += 5; 
        }

        Console.WriteLine($"You listed {items.Count} items");
        EndMessage();
    }
}
         
         
         

            
            
            


            
        

    
    
    
    
    


