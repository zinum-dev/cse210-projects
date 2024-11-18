class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        //"John 3:16" or "Proverbs 3:5-6"
        string reference = $"{_book} {_chapter}:{_verse}";
        if (_endVerse != 0 )
        {
            reference += $"-{_endVerse}";
        }
        return reference;
    }
}