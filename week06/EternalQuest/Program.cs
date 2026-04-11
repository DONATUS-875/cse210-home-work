// Creativity
// This program goes beyond the core requirements where I added the gamification elements such as
// a leveling system (users level up every 1000 points) and badges (e.g, Persistence badge, goal setter badge.)
// These features motivate users with rewards and celebrations, making goal tracking more engaging and fun.



using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event.");
            Console.WriteLine("3. Show Goals.");
            Console.WriteLine("4. Show Scores.");
            Console.WriteLine("5. Save Goals.");
            Console.WriteLine("6. Load Goals.");
            Console.WriteLine("7. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.RecordEvent(); break;
                case "3": manager.DisplayGoals(); break;
                case "4": manager.DisplayScore(); break;
                case "5": manager.SaveGoals(); break;
                case "6": manager.LoadGoals(); break;
                case "7": running = false; break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }
}
        
    
