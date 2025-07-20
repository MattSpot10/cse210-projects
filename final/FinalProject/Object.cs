using System.Dynamic;
using System.Runtime.CompilerServices;

abstract class Object
{
    private int _x;
    private int _y;
    private int _width;
    private int _height;
    private int _columns;
    private int _rows;
    private bool _shotAt = false;
    char[,] _shape;
    char[,] _shape2;
    bool _state = false;
    bool _visable = true;

    public int GetX()
    {
        return _x;
    }
    public int GetY()
    {
        return _y;
    }
    public bool GetVisable()
    {
        return _visable;
    }
    public void SetVisable(bool visable)
    {
        _visable = visable;
    }
    public void SetX(int x)
    {
        _x = x;
    }
    public void SetY(int y)
    {
        _y = y;
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
        if (_state)
        {
            return _shape2;
        }
        return _shape;
    }
    public void SetShape(bool state)
    {
        _state = state;
    }
    public bool GetState()
    {
        return _state;
    }

    public Object(int x, int y, int width, int height, char[,] shape, char[,] shape2, int columns, int rows, bool visable = true, bool shotAt = false, bool state = false)
    {
        _x = x;
        _y = y;
        _width = width;
        _height = height;
        _columns = columns;
        _rows = rows;
        _shotAt = shotAt;
        _shape = shape;
        _shape2 = shape2;
        _visable = visable;
        _state = state;
    }
    public bool MoveRight(bool execute = true)
    {
        if (_x + 1 > _columns - _width)
        {
            return false;
        }
        if (execute)
        {
            _x += 1;
        }
        return true;
    }
    public bool MoveLeft(bool execute = true)
    {
        if (_x - 1 < 0)
        {
            return false;
        }
        if (execute)
        {
            _x -= 1;
        }
        return true;
    }
    public bool MoveDown(bool execute = true)
    {
        if (_y + 1 > _rows - _height)
        {
            return false;
        }
        if (execute)
        {
            _y += 1;
        }
        return true;
    }
    public bool MoveUp(bool execute = true)
    {
        if (_y - 1 < 0)
        {
            return false;
        }
        if (execute)
        {
            _y -= 1;
        }
        return true;
    }
    public void ToggleShape()
    {
        _state = !_state;
    }
    public bool IsXY(int x, int y)
    {
        if (!_visable) { return false; }//if the object is not visable return false
        for (int i = 0; i < _width; i++)
        {
            for (int j = 0; j < _height; j++)
            {
                if (_x + i == x && _y + j == y)
                {
                    return true;
                }
            }
        }
        return false;
    }
    abstract public void ShotAt();
}