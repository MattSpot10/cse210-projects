using System;

class Program
{
    static void Main(string[] args)
    {



        List<int> myNumbers = new List<int>();

        myNumbers.Add(99);
        myNumbers.Add(46);
        myNumbers.Add(35);
        
        myNumbers.Add(39);
        List<int> myNumbers2 = myNumbers.Append(67).ToList();

        foreach (int i in myNumbers) {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        foreach (int i in myNumbers2) {
            Console.WriteLine(i);
        }

        Console.WriteLine("Hello Sandbox World!");

        Console.WriteLine("Hey how are you?");
        
    }
}