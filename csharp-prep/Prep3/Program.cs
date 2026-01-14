using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep 3 World!");
        Console.Write("What is the magic number? ");
        int magic = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int number = int.Parse(Console.ReadLine());

        while (number != magic)
        {
            Console.Write("Not quite... ");
            if (number < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (number > magic)
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            number = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("You Guessed It!");

    }
}