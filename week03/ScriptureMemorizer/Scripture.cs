// Keeps track of all the reference and the text of the scripture. Can hide words and the rendered display of text.

public class Scripture
{
    private Reference _reference; // The scripture reference (book, chapter, verse)

    private List<Word> _words; //the words in the scripture text

    // Constructor: sets the reference and splits the text into words
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into individual words and store them
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }


    // Hide certain number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;

        //This keeps hiding words until we reach the requested number or until all words are hidden
        while (wordsHidden < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count); // pick a random word
            if (!_words[index].IsHidden())  // only hide if not hidden yet
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }


    // Gets the scripture text ready to display (with hidden words displayed)
    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}";
        displayText += string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return displayText;
    }


    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) //if at least one is not hidden, return false
            {
                return false;
            }
        }
        return true;
    }
}