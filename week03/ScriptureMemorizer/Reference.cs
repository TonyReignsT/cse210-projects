// Keeps track of book, chapter, and verse information.
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    // Constructor for single verse reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;  // Single verse, so endVerse is same as verse
    }


    // Constructor for a verse range reference
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }


    // Returns the formatted scripture reference
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            // For single verse (e.g "John 3:16")
            return $"{_book} {_chapter}: {_verse}";
        }
        else
        {
            // For verse range (e.g. "Proverbs 3:5-6")
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}