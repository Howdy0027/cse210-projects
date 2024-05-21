public class Reference
{
    private string _book; // Book name of the scripture
    private int _chapter; // Chapter number
    private int _verse; // Starting verse number
    private int _endVerse; // Ending verse number (for a range of verses)

    // Constructor: Initializes a reference for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // Single verse
    }

    // Constructor: Initializes a reference for a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Method: Returns the reference text in a readable format
    public string GetDisplayText()
    {
        return _verse == _endVerse
            ? $"{_book} {_chapter}:{_verse}"
            : $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}
