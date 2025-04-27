using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?: ");

        string grade = Console.ReadLine();
        float percent = float.Parse(grade);
        string letterGrade = "";

        if (percent >= 90) {
            letterGrade = "A";
        }
        else if (percent >= 80) {
            letterGrade = "B";
        }
        else if (percent >= 70) {
            letterGrade = "C";
        }
        else if (percent >= 60) {
            letterGrade = "D";
        }
        else if (percent < 60 ) {
            letterGrade = "F";
        }

        Console.WriteLine($"Your Grade is a {letterGrade}");
        if (percent > 70) {
            Console.WriteLine("Congradualtions you passed your class!");
        }
        else {
            Console.WriteLine("Unfortunately you didn't pass but there is always next time!");
        }
    }
}