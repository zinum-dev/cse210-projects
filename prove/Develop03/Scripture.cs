using System.Text;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

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
    }


    public void HideRandomWords(int numberToHide)
    {

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
        return false;
    }
}