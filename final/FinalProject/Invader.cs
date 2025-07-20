class Invader : Object
{
    private static readonly char[,] _shape = { { 'X', 'X', 'X' }, { 'X', 'X', 'X' } };
    private static readonly char[,] _shape2 = { { '.', '.', '.' }, { '.', '.', '.' } };

    public Invader(int x, int y, int width, int height) : base(x, y, 3, 2, _shape, _shape2, width, height) { }


    public override void ShotAt()
    {
        SetVisable(false);//the invader is shot
    }

}