using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess;

        Console.WriteLine("I have chosen a magic number between 1 and 100.");

        do
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Please enter a whole number.");
                continue;
            }

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }                    
        while (guess != magicNumber);

        Console.WriteLine($"Correct! The magic number was {magicNumber}.");
    }
}