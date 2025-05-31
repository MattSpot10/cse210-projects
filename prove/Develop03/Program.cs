using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture[] scptrs = new Scripture[] {
            new Scripture("John 3:17", "For God sent not his Son into the world to condemn the world; but that the world through him might be saved."),
            new Scripture("2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture("Alma 32:21", "And now, as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."),
            new Scripture("Mosiah 3:19", "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and endureth all things while being humble and meek, and submissive, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."),
        };
        while (true)
        {
            Console.Clear();
            for (int i = 0; i < scptrs.Count(); i++)
            {
                Console.WriteLine($"{i + 1}: {scptrs[i].GetScriptureReference()}");
            }
            Console.WriteLine("q: to quit");


            int scptrIndex = -1;
            string input = Console.ReadLine();
            if (int.TryParse(input, out scptrIndex))
            {
                scptrIndex -= 1;
            }
            else
            {
                if (input == "q")
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            if (0 <= scptrIndex && scptrIndex < scptrs.Count())
            {
                while (true)
                {
                    Console.Clear();
                    scptrs[scptrIndex].DisplayScripture();
                    string str = Console.ReadLine();
                    if (scptrs[scptrIndex].RemoveWords(3) == 0)
                    {
                        break;
                    }
                    if (str == "q")
                    {
                        break;
                    }
                }
                scptrs[scptrIndex].resetWords();
            }
        }
    }
}