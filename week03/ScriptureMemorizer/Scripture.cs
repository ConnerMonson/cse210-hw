class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;


    public Scripture(Reference reference, string text)
    {
          _reference = reference;

        string[] cleanText = text.Split(' ');

        foreach (string word in cleanText)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() != true)
            {
                return false;
            }
        }
        return true;
    }

}