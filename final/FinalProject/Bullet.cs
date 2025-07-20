class Bullet : Object
{
    private static readonly char[,] _shape = { { '|' } };
    private static readonly char[,] _shape2 = { { '|' } };
    public Bullet(int x, int y, int width, int height) : base(x, y, 1, 1, _shape, _shape2, width, height, false) { }
    public override void ShotAt()
    {
        //do nothing
    }
    public void ProcessBullet(SpaceInvdadersGame game)
    {
        if (GetVisable())
        {
            if (!MoveUp(true))
            {
                SetVisable(false);//the bullet is off the screen
            }

            for (int i = 0; i < game.GetBarriers().Count; i++)//check if the bullet hit a barrier
            {
                if (game.GetBarriers()[i].IsXY(this.GetX(), this.GetY()))
                {
                    SetVisable(false);//the bullet hit a barrier
                }
            }

            for (int i = 0; i < game.GetInvaders().Count; i++)//check if the bullet hit an invader
            {
                if (game.GetInvaders()[i].IsXY(this.GetX(), this.GetY()))
                {
                    game.GetInvaders()[i].ShotAt();
                    SetVisable(false);//the bullet hit an invader
                }
            }

            if (game.GetPlayer().IsXY(this.GetX(), this.GetY()))//check if the bullet hit the player
            {
                game.GetPlayer().ShotAt();
                SetVisable(false);//the bullet hit the player
            }
        }
    }
}