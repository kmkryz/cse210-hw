
using System.Text.RegularExpressions;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private Word[] _words;

    public int _wordCount => _words.Length;
    public int _hiddenWordCount { get; private set; }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = ParseWords(text);
        _hiddenWordCount = 0;
    }

    private Word[] ParseWords(string text)
    {
        string[] wordStrings = Regex.Split(text, @"\W+");
        Word[] words = new Word[wordStrings.Length];

        for (int i = 0; i < wordStrings.Length; i++)
        {
            words[i] = new Word(wordStrings[i]);
        }

        return words;
    }

    public void HideWords(Random random)
    {
        for (int i = 0; i < _words.Length; i++)
        {
            if (random.Next(2) == 0 && !_words[i].IsHidden)
            {
                _words[i].Hide();
                _hiddenWordCount++;
            }

            Console.Write(_words[i].ToString() + " ");
        }
    }

    public override string ToString()
    {
        return $"{_reference}: {_text}";
    }
}
