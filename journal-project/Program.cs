using System;
using System.IO;

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
                        Entry entry = new();
                        entry.DisplayPrompt();
                        entry._userInput = Console.ReadLine();
                        journal.entries.Add(entry);
                        break;
                    case 2: // display
                        journal.DisplayEntries();
                        break;
                    case 3: // load
                        journal.LoadEntries();
                        break;
                    case 4: // save
                        journal.SaveEntry();
                        break;
                    case 5: // quit
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