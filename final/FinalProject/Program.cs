using System;

class Program
{
    static void Main(string[] args)
    {
        SpaceInvdadersGame _game = new SpaceInvdadersGame();

        _game.RenderFrame(' ');
        _game.DrawFrame();

        while (true)
        {
            char keyPressed = ' ';
            Thread.Sleep(500);
            while (Console.KeyAvailable)//get the last key by using a while loop.
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.KeyChar;
                // Process the key press
            }

            
            _game.RenderFrame(keyPressed);
            Console.Clear();
            _game.DrawFrame();
        }
    }
}