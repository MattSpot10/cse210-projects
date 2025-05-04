using System;





class Program
{
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        string s = Console.ReadLine();
        return int.Parse(s);
    }
    static int SquareNumber(int num) {
        return num*num;
    }
    static void DisplayResult(string name, int num) {
        Console.WriteLine($"{name}, the square of your number is {num}");
    } 



    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        num = SquareNumber(num);
        DisplayResult(name, num);
    }
}