using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

class Activity
{
    // Variables
    private string _name = "";
    private int _duration;
    private string _description = "";
    // Constructors
    public Activity()
    {

    }
    // Methods
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {GetName()}");
        Console.WriteLine();
        Console.WriteLine(GetDescription());

        Console.Write("How long, in seconds, would you like your session to be? ");
        int input = int.Parse(Console.ReadLine());
        SetDuration(input);

        // The activity actually starts here:
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowRickRoll(5);
    }
    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()}.");
        ShowSpinner(5);
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public static void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public static void ShowRickRoll(int seconds)
    {
        List<string> lyrics = new List<string> {
            "Never gonna", "give you up",
            "Never gonna", "let you down",
            "Never gonna", "run around", "and desert you",
            "Never gonna", "make you cry",
            "Never gonna", "say goodbye",
            "Never gonna", "tell a lie", "and hurt you"
        };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;


        while (DateTime.Now < endTime)
        {
            string s = lyrics[i];
            Console.Write(s);
            Thread.Sleep(350);
            Console.Write("\b \b");

            foreach (char c in s){
                Console.Write("\b \b");
            }
            i++;
            if (i >= lyrics.Count)
            {
                i = 0;
            }
        }
    }


    // Get and Set methods
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }

}