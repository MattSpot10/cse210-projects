using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

class Entry
{
    string _date;
    string _prompt;
    string _response;

    private static readonly List<string> _questions = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What brought you purpose today?",
    };

    public void CreateEntry()
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _prompt = _GetQuestionPrompt();
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();

    }
    public Entry() {}
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
    public string ToString(string format)
    {
        if (format == "txt")
        {
            return $"{_date}#{_prompt}#{_response}";
        }
        return $"\"{_date}\",\"{_prompt}\",\"{_response}\"";
    }
    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }
    public static string _GetQuestionPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count());
        return _questions[index];
    }
}