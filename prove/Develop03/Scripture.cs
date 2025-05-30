class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public void DisplayScripture()
    {
        _reference.DisplayReference();
        foreach (Word word in _words)
        {
            word.DispalyWord();
        }
    }
    public int RemoveWords(int numOfWords)//returns the number of visable words when finished
    {
        List<int> visableWords = new List<int>();//a list of all the indexes to the visable words in the list.
        for (int i = 0; i < _words.Count(); i++)
        {
            if (_words[i].IsVisable())
            {
                visableWords.Add(i);
            }
        }
        for (int i = 0; i < numOfWords; i++)
        {
            Random random = new Random();
            if (visableWords.Count() > 0)
            {
                int randomIndex = random.Next(0, visableWords.Count());
                _words[visableWords[randomIndex]].SetVisible(false);
                visableWords.RemoveAt(randomIndex);
            }
        }
        return visableWords.Count();
    }
    public void resetWords()
    {
        foreach (Word word in _words)
        {
            word.SetVisible(true);
        }
    }
    public Scripture(string reference, string body)
    {
        _reference = new Reference(reference);
        _SplitStringToWords(body);
    }
    public string GetScriptureReference()
    {
        return _reference.GetReference();
    }
    private void _SplitStringToWords(string text)
    {
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word myWord = new Word(word);
            _words.Add(myWord);
        }
    }
}