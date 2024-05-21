public class Word
{
    private string _text; // The text of the word
    private bool _isHidden; // Indicates whether the word is hidden

    // Constructor: Initializes the word with its text
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Method: Hides the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method: Reveals the word
    public void Show()
    {
        _isHidden = false;
    }

    // Method: Checks if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method: Returns the word text or a placeholder if hidden
    public string GetDisplayText()
    {
        return _isHidden ? "_____" : _text;
    }
}
