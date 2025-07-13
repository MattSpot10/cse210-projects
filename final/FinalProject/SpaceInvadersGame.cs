using System.Data;
using System.Runtime.CompilerServices;

class SpaceInvdadersGame
{
    private static readonly int _columns = 80;//x width
    private static readonly int _rows = 30;//y height
    private char[,] _frame = new char[_rows, _columns];

    //Barrier<List> _barriers = new Barrier<List>(4);

    public SpaceInvdadersGame()
    {
        ClearFrame();
    }

    public void ClearFrame()
    {
        for (int i = 0; i < _rows; i++)//y axis
        {
            for (int j = 0; j < _columns; j++)//x axis
            {
                _frame[i, j] = '1';
            }
        }
    }
    public void DrawFrame()
    {
        Console.Clear();
        for (int i = 0; i < _rows; i++)//y axis
        {
            for (int j = 0; j < _columns; j++)//x axis
            {
                Console.Write(_frame[i, j]);
            }
            Console.WriteLine();
        }
    }
    public void DrawOnFrame(Object myObject)
    {
        for (int i = 0; i < myObject.GetHeight(); i++)//y axis
        {
            for (int j = 0; j < myObject.GetWidth(); j++)//x axis
            {
                _frame[myObject.GetY() + i, myObject.GetX() + j] = myObject.GetShape()[i, j];
            }
        }
    }



}