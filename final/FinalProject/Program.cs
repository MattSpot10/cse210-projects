using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Space Invaders!");
        Console.WriteLine("Use 'a' and 'd' to move. and 's' to fire.");
        Console.WriteLine("Press any key to start the game.");

        Console.ReadKey();



        SpaceInvdadersGame _game = new SpaceInvdadersGame();

        _game.RenderFrame(' ');
        _game.DrawFrame();

        while (true)
        {
            char keyPressed = ' ';
            Thread.Sleep(150);
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