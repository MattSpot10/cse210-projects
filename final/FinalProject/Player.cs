class Player : Object
{
    Bullet bullet = new Bullet(0, 0);
    private static readonly char[,] _shape = { { 'A', 'B' }, { 'C', 'D' } };
    public Player(int x, int y) : base(x, y, 2, 2, _shape) { }
    public override void ShotAt()
    {

    }
}