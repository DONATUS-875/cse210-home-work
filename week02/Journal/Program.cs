using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();


        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save the Journal to a file");
            Console.WriteLine("4. Load the Journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string input = Console.ReadLine().Trim();

            if (!int.TryParse(input, out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            continue;
        }
            

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.Write("How was your mood today? ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToString("MM/dd/yyyy");
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }

            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!!");
            }

            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5");
            }
        }

        
    }
}
