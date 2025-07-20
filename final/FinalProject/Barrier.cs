class Barrier : Object
{
    private static readonly char[,] _shape = { { ' ', '_', '_', '_', '_', ' ' }, { '|', ' ', ' ', ' ', ' ', '|' }};
    private static readonly char[,] _shape2 = { { ' ', '_', '_', '_', '_', ' ' }, { '|', ' ', ' ', ' ', ' ', '|' }};
    public Barrier(int x, int y, int width, int height) : base(x, y, 6, 2, _shape, _shape2, width, height) { }
    public override void ShotAt()
    {

    }
}