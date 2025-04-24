using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Input your last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your first name is: {firstName}");
        Console.WriteLine($"Your last name is: {lastName}");

    }
}
