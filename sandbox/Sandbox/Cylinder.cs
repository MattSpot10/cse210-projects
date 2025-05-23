using System.Dynamic;
using System.Runtime.ConstrainedExecution;

class Cylinder
{
    private Circle _circle;
    private double _height;

    public Cylinder()
    {
        _circle = null;
        _height = 0.0;
    }
    public Cylinder(Circle circle)
    {
        _circle = circle;
        _height = 0.0;
    }
    public Cylinder(double height)
    {
        _circle = null;
        _height = height;
    }
    public Cylinder(Circle circle, double height)
    {
        _circle = circle;
        _height = height;
    }
    public Cylinder(double radius, double height)
    {
        _circle = new Circle(radius);
        _height = height;
    }

    public void SetCircle(Circle circle)
    {
        _circle = circle;
    }
    public void SetHeight(double height)
    {
        _height = height;
    }
    public double GetVolume()
    {
        return _circle.GetArea() * _height;
    }
}