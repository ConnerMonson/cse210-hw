// I added a mood rating to the entry class
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} Mood: {_mood}/5 Prompt: {_promptText} \n{_entryText}\n");
    }
}