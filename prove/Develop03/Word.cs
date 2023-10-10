public class Word
{
    private string _text;
    private bool _isHidden;

    public bool IsHidden => _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public override string ToString()
    {
        return _isHidden ? new string('█', _text.Length) : _text;
    }
}





