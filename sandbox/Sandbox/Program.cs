using System;
using System.Dynamic;
using Microsoft.Win32.SafeHandles;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");

        DateTime currentDate = DateTime.Now;
        DateTime endTime = currentDate.AddSeconds(9);
        int sleepTime = 250;
        int count = 9;
        int diration = 9;

        while (DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            Console.Write("\b");


            // currentDate = DateTime.Now;
            // Console.Write("/");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");

            // Console.Write("|");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");

            // Console.Write("\\");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");

            // Console.Write("-");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");
        }




    }
}


