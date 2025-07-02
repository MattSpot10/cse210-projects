public static class HelperFunctions
{
    public static int GetUserSelection(int min, int max)
    {
        int selection = 0;
        if (min == max)
        {
            throw new Exception("there is nothing in selection");
        }
        while (!int.TryParse(Console.ReadLine(), out selection) || selection < min || selection > max)
            {
                Console.WriteLine("Please enter a valid selection");
            }
        return selection;
    }
    public static int GetUserNumber()
    {
        int number = 0;

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Please enter a valid number");
        }
        return number;
    }
}