using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Activity Program!");
        Menu();

    }

    public static void Menu()
    {
        // Creating Variables



        bool IsRunning = true;
        while (IsRunning)
        {
            Console.WriteLine();
            Console.Write("Menu Options:\n1. Breathing Activity\n2. Refleciton Activity\n3. Listing Activity\n4. Quit\nChoice: ");
            string choice = Console.ReadLine();
            switch (int.Parse(choice))
            {
                case 1: // Breathing Activity
                    Breathing breathingActivity = new Breathing();
                    breathingActivity.Run();
                    break;
                case 2: // Reflection Activity
                    Reflection reflectionActivity = new Reflection();
                    reflectionActivity.Run();
                    break;
                case 3: // Listing Activity
                    Listing listingActivity = new Listing();
                    listingActivity.Run();
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    Console.WriteLine();
                    Console.WriteLine("Are you sure you want to end? (y/n)");
                    string response = Console.ReadLine();
                    if (response == "y" || response == "yes")
                    {
                        IsRunning = false;
                    }
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid number my guy...");
                    break;
            }
        }
        Console.WriteLine("Bye bye!");
    }
}