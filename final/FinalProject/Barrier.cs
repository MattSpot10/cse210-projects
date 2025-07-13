class Barrier : Object
{
    private static readonly char[,] _shape = { { 'A', 'B' }, { 'C', 'D' } };
    public Barrier(int x, int y) : base(x, y, 2, 2, _shape) { }
    public override void ShotAt()
    {

    }
}