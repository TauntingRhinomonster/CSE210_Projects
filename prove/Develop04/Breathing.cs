using System;

class Breathing : Activity
{
    // Constructors
    public Breathing()
    {
        // Variables
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    // Methods
    public void Run()
    {
        StartMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        EndMessage();
    }
}