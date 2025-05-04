using System;

class Program
{
    static void Main(string[] args)
    {
        

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = 0;
        while(true) {
            Console.WriteLine("Enter number: ");
            string s = Console.ReadLine();
            number = int.Parse(s);
            if (number == 0) {
                break;
            }
            numbers.Add(number);
        }


        int max_val = numbers[0];
        int min_val = numbers[0];
        int total = numbers[0];
        for (int i = 1; i < numbers.Count; i++) {
            total += numbers[i];
            if (numbers[i] > max_val) {
                max_val = numbers[i];
            }
            if (numbers[i] < min_val) {
                min_val = numbers[i];
            }
        }

        float average = (float)total / (float)numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max_val}");
        Console.WriteLine($"The smallest number is: {min_val}");


    }
}