using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment myMathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment myWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine();
        Console.WriteLine(myMathAssignment.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(myWritingAssignment.GetWritingInformation());



        // Console.WriteLine("Hello Learning04 World!");
    }
}