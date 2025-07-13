class Invader : Object
{
    private static readonly char[,] _shape = { { 'A', 'B' }, { 'C', 'D' } };

    public Invader(int x, int y) : base(x, y, 2, 2, _shape) { }

}