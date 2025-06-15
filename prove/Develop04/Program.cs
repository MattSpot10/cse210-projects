using System;

class Program
{
    static void Main(string[] args)
    {


        // Console.WriteLine("Hello Develop04 World!");

        // Activity myActivity = new Activity("running", "moving my legs to propell me forward");

        // myActivity.Counter(5);

        // myActivity.DisplayStartMessage();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: \n1. Start breathing activity \n2. Start reflection activity \n3. Start listing activity \n4. Quit");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunBreathingActivity();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.RunReflectingActivity();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunListingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Enter a valid choice.\n");
                    break;

            }
        }
    }
}