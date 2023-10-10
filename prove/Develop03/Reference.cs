

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string reference)
    {
        ParseReference(reference);
    }

    private void ParseReference(string reference)
    {
        // Split the reference by spaces, colons, and hyphens
        string[] parts = reference.Split(new char[] { ' ', ':', '-' });

        if (parts.Length < 3)
        {
            throw new ArgumentException("Invalid scripture reference format.");
        }

        // Extract the book name
        _book = parts[0];

        // Parse the chapter and verse numbers
        if (!int.TryParse(parts[1], out _chapter))
        {
            throw new ArgumentException("Invalid chapter format.");
        }

        if (!int.TryParse(parts[2], out _verseStart))
        {
            throw new ArgumentException("Invalid verse start format.");
        }

        // If there is a hyphen, parse the ending verse
        if (parts.Length > 3)
        {
            if (!int.TryParse(parts[3], out _verseEnd))
            {
                throw new ArgumentException("Invalid verse end format.");
            }
        }
        else
        {
            _verseEnd = _verseStart; // Set the ending verse to the same as the starting verse
        }
    }

    public override string ToString()
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}






