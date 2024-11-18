using System.Text;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private int _hiddenCount;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string part in words)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
        _hiddenCount = 0;
    }


    public void HideRandomWords()
    {
        int numberToHide = (_words.Count/10) + 1;
        Random random = new Random();
        for(int i=0;i<numberToHide;i++)
        {
            if( _hiddenCount < _words.Count)
            {
                int randomNumber = random.Next(0,_words.Count);
                if(!_words[randomNumber].IsHidden())
                {
                    _words[randomNumber].Hide();
                    _hiddenCount++;
                }
                else
                {
                    i--;
                }
            }
        }
    }

    public string GetDisplayText()
    {
        StringBuilder displayText = new StringBuilder($"{_reference.GetDisplayText()}");
        displayText.Append(' ');
        foreach (Word word in _words)
        {
            displayText.Append(word.GetDisplayText());
            displayText.Append(' ');
        }

        return displayText.ToString();
    }

    public bool IsCompletelyHidden()
    {
        return _hiddenCount >= _words.Count;
    }
}