namespace WordCounter;

public class Counter
{
    private string _text => File.ReadAllText(_path);
    private string _path;
    private StreamReader _stream;
    private int _lineCount;
    private int _charCount;
    private string[] words;

    public Counter(string path)
    {
        _path = path;
    }

    public void CountChars()
    {
        _charCount = _text.Count(c => char.IsLetter(c));
        Console.WriteLine(_charCount + " Letters in text");
    }

    public void CountWords()
    {
        words = _text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Length + " words in text");

    }

    public void CountLines()
    {
        _stream = new StreamReader(_path);
        using (_stream)
        {
           while (_stream.ReadLine() != null)
            {
                _lineCount++;
            }
        }

        Console.WriteLine(_lineCount + " Lines in text");
    }
}