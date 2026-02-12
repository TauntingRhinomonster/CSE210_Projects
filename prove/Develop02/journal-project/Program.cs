using System;
using System.IO;

// When you save, it should prompt the user where they want to save their file. When you load, it should ask the user what file name they want to load.

namespace Main
{
    public class Program
    {
        public static void Main(string[] Args)
        {
            Journal journal = new Journal();
            int choice = journal.DisplayMenu();
            while (choice != 5)
            {
                switch (choice)
                {
                    case 1: // write
                        Entry entry = new Entry();
                        entry.DisplayPrompt();
                        entry._userInput = Console.ReadLine();
                        entry._userRating = Entry.PromptRating();
                        journal._entries.Add(entry);
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