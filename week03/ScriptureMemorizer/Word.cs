// Keeps track of a single word and whether it is shown or hidden

public class Word
{
    // Private member variables
    private string _text; // Actual word text
    private bool _isHidden; // Tracks if word is hidden  (true) or shown (false)


    //Constructor: initialize a new word
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // If is hidden, return underscores matching word length. 
            return new string('_', _text.Length);
        }
        else
        {
            // If not hidden, return actual word
            return _text;
        }
    }
}