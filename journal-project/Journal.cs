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
            string filename = "myFile.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry.CreateFormattedString()}");
                }
            }
        }
        public void LoadEntries()
        {
            // This first line will make sure that your journal object has nothing in it,
            // so when you first load the file, it will not duplicate anything if you accidentally
            // loaded twice in a row.
            _entries.Clear();
            string filename = "myFile.txt";
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
        }
    }
}