using System;

namespace Main
{
    public class Program
    {
        public static void Main(string[] Args)
        {
            Journal journal = new();
            int choice = journal.DisplayMenu();
            while (choice != 5)
            {
                switch (choice)
                {
                    case 1: // write
                        Console.WriteLine("case 1");
                        Entry entry = new();
                        entry.DisplayPrompt();
                        entry._userInput = Console.ReadLine();
                        journal.entries.Add(entry);
                        break;
                    case 2: // display
                        Console.WriteLine("case 2");
                        journal.DisplayEntries();
                        break;
                    case 3: // load
                        Console.WriteLine("case 3");
                        break;
                    case 4: // save
                        Console.WriteLine("case 4");
                        break;
                    case 5: // quit
                        Console.WriteLine("case 5");
                        break;
                    default:
                        Console.WriteLine("Please choose a number between 1 and 5.");
                        break;
                }
                choice = journal.DisplayMenu();
            }
        }
    }
}