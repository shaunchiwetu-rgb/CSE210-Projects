using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
    

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."
            ),

            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."
            ),

            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            ),

            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want."
            ),

            new Scripture(
                new Reference("Joshua", 1, 9),
                "Be strong and of a good courage be not afraid neither be thou dismayed for the Lord thy God is with thee whithersoever thou goest."
            )
        };

        
        Random random = new Random();

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press ENTER to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                return;
            }

            scripture.HideRandomWords(3);
        }

        
        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Congratulations! You memorized the scripture!");
    }
}