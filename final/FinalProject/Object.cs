using System.Dynamic;
using System.Runtime.CompilerServices;

abstract class Object
{
    private int _x;
    private int _y;
    private int _width;
    private int _height;
    private bool _shotAt = false;
    char[,] _shape;

    public int GetX()
    {
        return _x;
    }
    public int GetY()
    {
        return _y;
    }
    public int GetWidth()
    {
        return _width;
    }
    public int GetHeight()
    {
        return _height;
    }
    public char[,] GetShape()
    {
        return _shape;
    }

    public Object(int x, int y, int width, int height, char[,] shape, bool shotAt = false)
    {
        _x = x;
        _y = y;
        _width = width;
        _height = height;
        _shotAt = shotAt;
        _shape = shape;
    }
    public void MoveRight()
    {
        _x += 1;
    }
    public void MoveLeft()
    {
        _x -= 1;
    }
    public void MoveDown()
    {
        _y += 1;
    }
    abstract public void ShotAt();
}