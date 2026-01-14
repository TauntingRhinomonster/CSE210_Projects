using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep 4 World!");
        List<double> numbers = new List<double>();
        // numbers.Add(12);
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }
        double input = 1; // Just setting it to something random so that I can start the while loop.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (input != 0)
        {
            Console.Write("Enter a number: ");
            input = double.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int count = 0;
        double average;
        double sum = 0;
        double largest = 0;
        numbers.Sort();
        foreach (double number in numbers)
        {
            sum += number;
            count += 1;
            if (number > largest)
            {
                largest = number;
            }
        }
        average = sum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine("The sorted list is:");
        foreach (double number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}