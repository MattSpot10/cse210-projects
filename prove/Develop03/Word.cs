using System.Diagnostics.CodeAnalysis;

class Word
{
    string _word;
    bool _isVisable;

    public Word(string word, bool visable)
    {
        _word = word;
        _isVisable = visable;
    }
    public Word(string word)
    {
        _word = word;
        _isVisable = true;
    }

    public void DispalyWord()
    {
        if (_isVisable)
        {
            Console.Write(_word + " ");
        }
        else
        {
            Console.Write(new string('_', _word.Count()) + " ");
        }
    }
    public void SetVisible(bool visable)
    {
        _isVisable = visable;
    }
    public bool IsVisable()
    {
        return _isVisable;
    }
}