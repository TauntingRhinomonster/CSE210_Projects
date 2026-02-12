using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
namespace Main
{
    public class Journal
    {
        public List<Entry> _entries = new();
        public Journal()
        {
        }

        public void DisplayEntries()
        {
            // call the function in entires which would be a void funciton which gets all the info for each entry.
            // loop through the list and print each entry.
            foreach (Entry entry in _entries)
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
        public void SaveEntry()
        {
            Console.WriteLine("What file do you want to save to? Don't include the '.txt' at the end of your name.");
            string filename = $"{Console.ReadLine()}.txt";

            using (StreamWriter outputFile = new StreamWriter(filename, true))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry.CreateFormattedString()}");
                }
            }
            Console.WriteLine($"Saving Successful! When you open this program again, you can now load your entries in {filename}");
        }
        public void LoadEntries()
        {
            // This first line will make sure that your journal object has nothing in it,
            // so when you first load the file, it will not duplicate anything if you accidentally
            // loaded twice in a row.
            _entries.Clear();
            Console.WriteLine("What file do you want to load? Don't include the '.txt' at the end of your name.");
            string filename = $"{Console.ReadLine()}.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                string time = parts[0];
                string prompt = parts[1];
                string userInput = parts[2];
                string userRating = parts[3];
                Entry entry = new(time, prompt, userInput, userRating);
                _entries.Add(entry);
                // The problem is that there is no separation between each fragment of each entry. 
                // Entry has a date, a prompt, and a userInput.
                // There is no way to redisplay what is a date, a prompt, and a userInput
            }
            Console.WriteLine($"Loading Successful! You can now display your entries that were saved in {filename}");
        }
    }
}