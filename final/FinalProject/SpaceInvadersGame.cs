using System.Data;
using System.Dynamic;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

class SpaceInvdadersGame
{
    private static readonly int _columns = 60;//x width
    private static readonly int _rows = 20;//y height

    private int invaderDir = 1;// 1 is to the right -1 is to the left
    private char[,] _frame = new char[_rows, _columns];

    private List<Invader> _invaders = new List<Invader>(10)
    {
        new Invader(_columns / 10, 1, _columns, _rows),
        new Invader((_columns / 10) * 2, 1, _columns, _rows),
        new Invader((_columns / 10) * 3, 1, _columns, _rows),
        new Invader((_columns / 10) * 4, 1, _columns, _rows),
        new Invader((_columns / 10) * 5, 1, _columns, _rows),

        new Invader(_columns / 10, 5, _columns, _rows),
        new Invader((_columns / 10) * 2, 5, _columns, _rows),
        new Invader((_columns / 10) * 3, 5, _columns, _rows),
        new Invader((_columns / 10) * 4, 5, _columns, _rows),
        new Invader((_columns / 10) * 5, 5, _columns, _rows)
    };

    private List<Barrier> _barriers = new List<Barrier>(4)
    {
        new Barrier(_columns / 5 - 3, _rows - 5, _columns, _rows),
        new Barrier((_columns / 5) * 2 - 3, _rows - 5, _columns, _rows),
        new Barrier((_columns / 5) * 3 - 3, _rows - 5, _columns, _rows),
        new Barrier((_columns / 5) * 4 - 3, _rows - 5, _columns, _rows)
    };

    private Player _player = new Player(5, _rows - 2, _columns, _rows);

    //Barrier<List> _barriers = new Barrier<List>(4);

    public SpaceInvdadersGame()
    {
        ClearFrame();
    }

    public void ClearFrame()
    {
        for (int i = 0; i < _rows; i++)//y axis
        {
            _frame[i, 0] = '|';
            for (int j = 1; j < _columns - 1; j++)//x axis
            {
                if (i == 0 || i == _rows - 1)
                {
                    _frame[i, j] = '&';
                }
                else
                {
                    _frame[i, j] = ' ';
                }
            }
            _frame[i, _columns - 1] = '|';
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
    public void RenderFrame(char userinput)
    {
        ClearFrame();

        //Draw player
        if (userinput == 'a')
        {
            _player.MoveLeft();
            _player.MoveLeft();
        }
        if (userinput == 'd')
        {
            _player.MoveRight();
            _player.MoveRight();
        }
        if (userinput == 's')
        {
            if (_player.GetBullet().GetVisable() == false)//if the bullet is not visable shoot.
            {
                _player.ShootBullet();
            }
        }

        DrawOnFrame(_player);
        _player.GetBullet().ProcessBullet(this);//process the bullet
        DrawOnFrame(_player.GetBullet());


        //draw barriers
        foreach (Barrier barrier in _barriers)
        {
            DrawOnFrame(barrier);
        }


        //Move invaders 
        bool moveDown = false;

        foreach (Invader invader in _invaders)
        {
            if (invader.GetX() == _columns - invader.GetWidth())
            {
                if (invaderDir != -1)
                {
                    moveDown = true;
                }
                invaderDir = -1;
            }
            if (invader.GetX() == 0)
            {
                if (invaderDir != 1)
                {
                    moveDown = true;
                }
                invaderDir = 1;
            }
        }


        foreach (Invader invader in _invaders)//preforme the move
        {
            invader.ToggleShape();
            if (moveDown == true)
            {
                invader.MoveDown();
            }
            else if (invaderDir == 1)
            {
                invader.MoveRight();
            }
            else
            {
                invader.MoveLeft();
            }
            DrawOnFrame(invader);
        }




        DrawFrame();
    }
    public void DrawOnFrame(Object myObject)
    {
        if (myObject.GetVisable())
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
    public List<Invader> GetInvaders()
    {
        return _invaders;
    }
    public Player GetPlayer()
    {
        return _player;
    }
    public List<Barrier> GetBarriers()
    {
        return _barriers;
    }




}