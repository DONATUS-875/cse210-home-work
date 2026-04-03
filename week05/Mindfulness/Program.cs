// showing creativity and exceeding requirements:
// I added "GratitudeActivity" and "Activity Log" to the program
// To keep track on how many times the activities are been run. 

using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;
        int gratitudeCount = 0;

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Show Activity Log");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathingCount++;
                Console.WriteLine("Breathing activity finished, inreamenting counter...");
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Run();
                reflectionCount++;
                Console.WriteLine("Reflection activity finished, increamenting counter...");
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listingCount++;
                Console.WriteLine("Listing activity finished, increamenting counter...");
            }
            else if (choice == "4")
            {
                GratitudeActivity gratitudeActivity = new GratitudeActivity();
                gratitudeActivity.Run();
                gratitudeCount++;
            }
            else if (choice == "5")
            {
                Console.WriteLine("Activity Log:");
                Console.WriteLine($"Breathing Activity: {breathingCount} times");
                Console.WriteLine($"Reflection Activity: {reflectionCount} times");
                Console.WriteLine($"Listing Activity: {listingCount} times");
                Console.WriteLine($"Gratitude Activity: {gratitudeCount} times");
            }
            else if (choice == "6")
            {
                break;
            }
        }
    }
}

        
    
