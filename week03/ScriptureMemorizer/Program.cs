// I added a random number generator to choose how many words hide that loop.

class Program
{
    static void Main()
    {
        // New reference
        Reference reference = new Reference( "John", 3, 16);

        // Scripture text
        string text = "For God so loved the world that He gave His only begotten Son, That whosoever believeth in Him should not perish, but have everlasting life.";

        // New Scripture
        Scripture scripture = new Scripture(reference, text);

        // Clear Console, and Display scripture for first time
        Console.Clear();
        Console.WriteLine($"{reference.GetDisplayText()} {text}");

        Random random = new Random();
        string userInput = "";
        while (userInput != "quit")
        {
            // Display user options, enter or "quit" //
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            // if enter, then remove random words, and reset//
            if (userInput == "" && scripture.IsCompletelyHidden() == false)
            {
                // Random number of words to hide 
                int numberToHide = random.Next(2, 5);
                scripture.HideRandomWords(numberToHide);

                // Clear console
                Console.Clear();

                // Display updated reference + scripture
                Console.WriteLine(scripture.GetDisplayText());
            }
            // else if 'quit', then stop program
            else if (userInput == "quit" || scripture.IsCompletelyHidden() == true)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        }
    }
}