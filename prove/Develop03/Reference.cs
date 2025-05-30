using System.ComponentModel.DataAnnotations;

class Reference
{
    string _reference;

    public Reference(string reference)
    {
        _reference = reference;
    }
    public void DisplayReference()
    {
        Console.Write(_reference + ' ');
    }
    public string GetReference()
    {
        return _reference;
    }

}