using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep 5 World!");


        // Calling each function to test
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int year = PromptUserBirthYear();
        int squared = SquareNumber(number);
        DisplayResults(name, squared, year);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int PromptUserBirthYear()
    {
        Console.WriteLine("When were you born? ");
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        return year;
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResults(string name, int squared, int year)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - year;
        Console.WriteLine($"{name}, the square of your number is {squared}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}