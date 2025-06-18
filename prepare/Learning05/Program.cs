using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> myShapes = new List<Shape>();

        Square mySquare = new Square("red", 50);
        Circle myCircle = new Circle("green", 20);
        Rectange myRectange = new Rectange("brown", 20, 40);

        myShapes.Add(mySquare);
        myShapes.Add(myCircle);
        myShapes.Add(myRectange);


        foreach (Shape shape in myShapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }



    }
}