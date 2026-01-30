using System;
using System.ComponentModel.DataAnnotations;
namespace Main
{
    public class Journal
    {
        public List<Entry> entries = new();
        public Journal()
        {
        }

        public void DisplayEntries()
        {
            // call the function in entires which would be a void funciton which gets all the info for each entry.
            // loop through the list and print each entry.
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.DisplayEntry());
            }
        }
        public int DisplayMenu()
        {
            Console.WriteLine("Please select one of the following:\n1: Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static void SaveEntry()
        {
            // Code goes here lol
        }
    }
}