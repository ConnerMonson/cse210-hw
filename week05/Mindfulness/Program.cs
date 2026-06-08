using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "0";

        while (userInput != "4")
        {
            // Menu
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
            new BreathingActivity().Run();
            }
            else if (userInput == "2")
            {
            new ReflectingActivity().Run();

            }
            else if (userInput == "3")
            {
            new ListingActivity().Run();
            }
        }
    }
}