using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.IO;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        // Variables for my fwend :D
        int score = 0;
        List<Goal> goals = new();
        bool playing = true;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Hello everyone. Welcome to the ULTIMATE GOAL SETTING PROGRAM!!!!\nThis is where the fun happens and people accomplish their wildest dreams. This is pretty simple. You will simply choose to set goals and follow up on how everything is doing.");

        // Doing the stuff
        while (playing)
        {
            DisplayMenu();
            string input = Console.ReadLine();
            int userInput = int.Parse(input);
            switch (userInput)
            {
                case 1:
                    DisplayGoalMenu();
                    string choice = Console.ReadLine();
                    int userChoice = int.Parse(choice);

                    // put a way for a user to actually create a new goal
                    // 1. Simple
                    // 2. Eternal
                    // 3. Checklist
                    Console.Write("How many points will be alloted to completing this goal? ");
                    // Catch the user trying to enter an invalid number. This will catch it without breaking my program.
                    int points;
                    while (!int.TryParse(Console.ReadLine(), out points))
                    {
                        Console.WriteLine("Invalid number. Try again:");
                    }
                    Console.Write("What will be the name of this goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What will be the description of this goal? ");
                    string description = Console.ReadLine();
                    switch (userChoice)
                    {
                        case 1:
                            SimpleGoal simple = new SimpleGoal(points, name, description);
                            goals.Add(simple);
                            break;
                        case 2:
                            EternalGoal eternal = new EternalGoal(points, name, description);
                            goals.Add(eternal);
                            break;
                        case 3:
                            Console.WriteLine("Because of the goal you have chosen, there are extra parameters before you can accomplish this goal. ");
                            Console.Write("How many times must you do this task before accomplishing this goal? ");
                            int progressGoal;
                            while (!int.TryParse(Console.ReadLine(), out progressGoal))
                            {
                                Console.WriteLine("Invalid number. Try again:");
                            }
                            Console.Write("How many BONUS points will be alloted to completing this goal? ");
                            int bonusPoints;
                            while (!int.TryParse(Console.ReadLine(), out bonusPoints))
                            {
                                Console.WriteLine("Invalid number. Try again:");
                            }
                            ChecklistGoal checklist = new ChecklistGoal(points, name, description, progressGoal, bonusPoints);
                            goals.Add(checklist);
                            break;
                        default:
                            Console.WriteLine("Please choose one of the valid options...");
                            break;
                    }
                    // this comes after the creation of the goal...
                    break;
                case 2:
                    DisplayGoalList(goals);
                    break;
                case 3:
                    Save(goals, score);
                    break;
                case 4:
                    Load(goals, ref score);
                    break;
                case 5:
                    int earned = Record(goals);
                    score += earned;
                    Console.WriteLine($"Your total score is now {score}!");
                    AutoSave(goals, score);
                    Console.WriteLine("Progress automatically saved to autosave.txt.");
                    break;
                default:
                    playing = false;
                    break;
            }
        }

    }

    // Methods of MADNESS :D
    public static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    public static void DisplayGoalMenu()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Menu Options:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal");
        Console.Write("Select a choice from the menu: ");
    }
    public static void Save(List<Goal> goals, int score)
    {
        // Do the thing
        Console.Write("What would you like to call this file? ");
        string userInput = Console.ReadLine();
        string filename = $"{userInput}.txt";

        using (StreamWriter outputFile = new StreamWriter(filename, false)) // Add false to overwrite the file each time it saves. FOR TESTING!!!
        {
            outputFile.WriteLine(score);
            // You can add text to the file with the WriteLine method
            foreach (Goal g in goals)
            {
                outputFile.WriteLine($"{g.SaveGoalStats()}");
            }
        }

    }
    public static void Load(List<Goal> goals, ref int score)
    {
        // AutoSave??
        goals.Clear();
        // Do the other thing
        Console.Write("What would you like to call this file? ");
        string userInput = Console.ReadLine();
        string filename = $"{userInput}.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("~|~");
            // int points, string name, string description, int progressGoal, int bonusPoints, int currentProgress
            string goalType = parts[0];
            int points = int.Parse(parts[1]);
            string name = parts[2];
            string description = parts[3];
            if (goalType == "ChecklistGoal")
            {
                int progressGoal = int.Parse(parts[4]);
                int bonusPoints = int.Parse(parts[5]);
                int currentProgress = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(points, name, description, progressGoal, bonusPoints, currentProgress);
                goals.Add(checklistGoal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal(points, name, description);
                goals.Add(eternal);
            }
            else if (goalType == "SimpleGoal")
            {
                bool isCompleted = bool.Parse(parts[4]);
                SimpleGoal simple = new SimpleGoal(points, name, description);
                if (isCompleted)
                {
                    simple.CompleteGoal();
                }
                goals.Add(simple);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Load was successful!");
        Console.WriteLine();
        DisplayGoalList(goals);
    }
    public static int Record(List<Goal> goals)
    {
        // Oh yeah baby! This is where stuff gets real!
        DisplayGoalList(goals);
        Console.Write("Which goal would you like to record for completion/incrementation? ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("That is an invalid number. Please choose one of the options:");
            DisplayGoalList(goals);
            Console.Write("Which goal would you like to record for completion/incrementation? ");
        }

        // Now for the actual mathematical stuff!!! Holy COW!!! It will be happening in this function.
        int actualIndex = choice - 1;
        int pointsEarned = goals[actualIndex].CompleteGoal();
        Console.WriteLine($"Congratulations ! You earned {pointsEarned} points!");
        return pointsEarned;

    }
    public static void DisplayGoalList(List<Goal> goals)
    {
        Console.WriteLine();
        int i = 1;
        // Iterate through a list of goals calling the goal object and it's individual display method.
        foreach (Goal g in goals)
        {
            Console.Write($"{i}. ");
            Console.WriteLine($"{g.DisplayGoalStats()}");
            i++;
        }
    }

    // Stretch Challenge!!!
    public static void AutoSave(List<Goal> goals, int score)
    {
        string filename = "autosave.txt";

        // The 'false' parameter overwrites the file so it only keeps the most recent save
        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            outputFile.WriteLine(score);
            foreach (Goal g in goals)
            {
                outputFile.WriteLine($"{g.SaveGoalStats()}");
            }
        }
    }
}