using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>();
        
        // Creativity:
        // This program exceed the core requirments where I introduced a library of scriptures.
        // Each run of the program randomly selects one scripture from the library,
        // which makes the memorization practice more engaging.


        library.Add(new Scripture(new Reference("John", 3, 16), 
        "For God so loved the world that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life."
        ));
        

        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), 
        "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy path"
        ));
        
        

        library.Add(new Scripture(new Reference("Psalm", 23, 1),   
        "The Lord is my shepherd; I shall not want"
        ));
        
        

        Random random = new Random();
        int index = random.Next(library.Count);
        Scripture scripture = library[index];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type quit to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

                scripture.HideRandomWords(3);

                if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words hidden. Program ending.");
                    break;
                
            }
        }
    }
}
