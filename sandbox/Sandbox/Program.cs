using System;
using System.Dynamic;
using Microsoft.Win32.SafeHandles;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");


        Circle myCircle = new Circle();
        myCircle.SetRadius(34);
        Console.WriteLine($"Radius: {myCircle.GetRadius()}");


        Cylinder myCylinder = new Cylinder();
        myCylinder.SetHeight(40);
        myCylinder.SetCircle(myCircle);

        Console.WriteLine(myCylinder.GetVolume());



    }
}


