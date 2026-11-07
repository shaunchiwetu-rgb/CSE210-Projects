using System;

class Program
{
    private static readonly string[] Prompts =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Random random = new Random();

        Console.WriteLine("Welcome to the Journal program!");

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                int index = random.Next(Prompts.Length);

                string selectedPrompt = Prompts[index];

                Console.WriteLine(selectedPrompt);

                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();

                newEntry._date = date;
                newEntry._prompt = selectedPrompt;
                newEntry._response = response;

                journal.AddEntry(newEntry);

                Console.WriteLine("Journal entry saved successfully");





            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the file name to load: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the file name : ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
