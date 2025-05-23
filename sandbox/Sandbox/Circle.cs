class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 0.0;
    }
    
    public Circle(double radius)
    {
        SetRadius(radius);

    }

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Error, radius must be > 0");
            return;
        }
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}