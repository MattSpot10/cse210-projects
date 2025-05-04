using System;
using System.Net.Sockets;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int input_number = 0;

        Console.WriteLine($"What is the magic number? (It's {number})");
        do {
            Console.WriteLine("What is your guess?");

            string line = Console.ReadLine();
            input_number = int.Parse(line);

            if (number > input_number) {
                Console.WriteLine("Higher");
            }
            if (number < input_number) {
                Console.WriteLine("Lower");
            }
        }
        while (number != input_number);
        Console.WriteLine("You guessed it!");


        
    }
}