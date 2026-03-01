using System;
using System.Collections.Generic;

class Listing : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        StartMessage();
        
        // 1. Get a random prompt
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        // 2. Loop and count
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine(); // We don't need to save the text, just the fact they typed it
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");
        
        EndMessage();
    }
}