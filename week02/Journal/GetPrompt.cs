public class GetPrompt
{
    List<string> _getPrompt = new List<string>()
    {
        "What is something small that made today better than yesterday?",
        "What emotion did I feel most strongly today, and what triggered it?",
        "What is one thing I avoided today, and why?",
        "If today had a title like a book or movie, what would it be?",
        "What is something Im grateful for that I usually overlook?",
        "What did I learn about myself today?",
        "What is one conversation from today that stayed in my mind?",
        "What would I do differently if I could redo today?",
        "What is one worry I have right now, and what is actually in my control about it?",
        "What is one small action I can take tomorrow to make the day better?"
    };
    public string GetRandomPrompt()
    {
        int index = Random.Shared.Next(_getPrompt.Count);
        string randomPrompt = _getPrompt[index];

        return randomPrompt;
    }
}
