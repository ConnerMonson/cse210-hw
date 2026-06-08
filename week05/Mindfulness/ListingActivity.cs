class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity()
    :base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayRandomPrompt();
        Console.Write("You may begin in:");
        ShowCountDown(10);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();

            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"    ---{prompt}---    ");
    }
}