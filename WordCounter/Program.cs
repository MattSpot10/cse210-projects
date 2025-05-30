class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        WordCounter wc = new WordCounter("how many words are in this text.");

        wc.DisplayWords();
    }
}