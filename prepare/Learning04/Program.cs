using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine();

        Assignment _HomeWork = new();
        Console.WriteLine(_HomeWork.GetSummary());
        Console.WriteLine();

        MathAssignment _MathHomeWork = new("Ryan Bierman", "Calculus", "4.6", "1-41");
        Console.WriteLine(_MathHomeWork.GetSummary());
        Console.WriteLine(_MathHomeWork.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment _WritingHW = new("Cara Horne", "English 301", "Annotated Bibliography");
        Console.WriteLine(_WritingHW.GetSummary());
        Console.WriteLine(_WritingHW.GetWritingInfo());
        Console.WriteLine();
    }
}