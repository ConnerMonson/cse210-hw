// I added a mood rating to the entry class.

using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        // Prompts
        Journal journal = new Journal();
        string userInput = "";
        while (userInput != "5")
        {
            Console.WriteLine("Welcome to the journal program");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1.Write \n2.Display \n3.Load \n4.Save \n5.Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();
            // Write
            if (userInput == "1")
            {
                // Date
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                // Random Prompt
                GetPrompt getPrompt = new GetPrompt();
                string randomPrompt = getPrompt.GetRandomPrompt();

                // Mood
                Console.Write("Rate your mood (1-5): ");
                string moodText = Console.ReadLine();
                // New Entry
                Console.Write($"{randomPrompt}\n>");
                string entryText = Console.ReadLine();

                Entry entry = new Entry();
                entry._date =  dateText;
                entry._promptText = randomPrompt;
                entry._entryText = entryText;
                entry._mood = moodText;
                journal.AddEntry(entry);
            }
            // Display
            else if (userInput == "2")
            {
                journal.DisplayAll();
            }
            // Load
            else if (userInput == "3")
            {
                Console.Write("Enter the file name: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            // Save
            else if (userInput == "4")
            {
                Console.Write("Enter the file name: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (userInput != "5")
            {
                Console.WriteLine("Invalid choice, Try again");
            }
        }
    }
}