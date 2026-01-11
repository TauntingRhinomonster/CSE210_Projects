using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep 2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);
        char grade = 'F';
        string sign = "";

        // Checking what the grade is
        if (percent >= 90)
        {
            grade = 'A';
        }
        else if (percent >= 80)
        {
            grade = 'B';   
        }
        else if (percent >= 70)
        {
            grade = 'C';
        }
        else if (percent >= 60)
        {
            grade = 'D';
        };

        if ((percent % 10 >= 5) || (percent >= 100))
        {
            sign = "+";
        }
        else
        {
            sign = "-";
        }

        // Fixing the A and F grading issue
        if (grade == 'A' && sign == "+")
        {
            sign = "";
        }
        else if (grade == 'F')
        {
            sign = "";
        }

        // Writing out the solution
        Console.WriteLine($"Your grade is: '{grade}{sign}'");
       
        // Telling the user if they passed their class
        if (percent < 70)
        {
            Console.WriteLine("You failed. Maybe try studying more. That might help.");
        }
        else
        {
            Console.WriteLine("You passed! Hurray!");
        }
    }
}