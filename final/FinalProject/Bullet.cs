class Bullet : Object
{
    private static readonly char[,] _shape = { { 'A', 'B' }, { 'C', 'D' } };
    public Bullet(int x, int y) : base(x, y, 2, 2, _shape) { }
    public override void ShotAt()
    {

    }
}