using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Would you like to play a number guessing game? (y/n)");
        string answer = Console.ReadLine();
        while (answer == "y")
        {
            Random random = new Random();
            int magic = random.Next(101);
            int guesses = 0;
            Console.WriteLine("There is a random number you need to guess from 0-100.");
            Console.Write("What is your guess? ");
            int number = int.Parse(Console.ReadLine());
            guesses += 1;

            while (number != magic)
            {
                Console.Write("Not quite... ");
                if (number < magic)
                {
                    Console.WriteLine("Higher");
                    guesses += 1;
                }
                else if (number > magic)
                {
                    Console.WriteLine("Lower");
                    guesses += 1;
                }
                Console.Write("What is your guess? ");
                number = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"You Guessed It!\nIt took you {guesses} tries.");
            Console.WriteLine("Would you like to play again? (y/n)");
            answer = Console.ReadLine();
        }
        Console.WriteLine("Bye bye!");
    }
}