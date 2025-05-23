using System;

class Program
{

    static void Main(string[] args)
    {

        Menu menu = new Menu();
        Journal myJournal = new Journal();

        bool quit = false;
        while (!quit)
        {
            menu.ProcessMenu(myJournal);
            quit = menu.Quit();
        }
    }
}