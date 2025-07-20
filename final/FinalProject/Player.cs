using System.Runtime.CompilerServices;

class Player : Object
{
    Bullet bullet = new Bullet(0, 0, 1, 1);

    int _initX = 0, _initY = 0;
    private static readonly char[,] _shape = { { 'M' } };
    private static readonly char[,] _shape2 = { { '?' } };
    public Player(int x, int y, int width, int height) : base(x, y, 1, 1, _shape, _shape2, width, height)
    {
        _initX = x;
        _initY = y;
        bullet = new Bullet(0, 0, width, height);
    }
    public override void ShotAt()
    {
        killPlayer();
    }

    public Bullet GetBullet()
    {
        return bullet;
    }
    public void killPlayer()
    {
        SetShape(true);//you died
    }
    public void ResetPlayer()
    {
        SetShape(false);//your alive
        SetX(_initX);
        SetY(_initY);
    }
    public void ShootBullet()
    {
        bullet.SetVisable(true);
        bullet.SetX(GetX());
        bullet.SetY(GetY());
    }
}