using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference; // Holds the scripture reference (book, chapter, verse(s))
    private List<Word> _words; // List of words in the scripture

    // Constructor: Initializes the scripture with a reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(word => new Word(word))
                     .ToList();
    }

    // Method: Hides a specified number of words randomly
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    // Method: Returns the scripture text with hidden words
    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {text}";
    }

    // Method: Checks if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
