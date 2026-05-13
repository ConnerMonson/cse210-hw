using System;
public class Entry
{
    public string _date;
    public string _PromptText;
    public string _entryText;
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} - {_PromptText} \n {_entryText}");
    }
}