using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2003;
        job1._endYear = 2019;
        Job.DisplayInfo(job1);

        Job job2 = new();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2019;
        job2._endYear = 2026;
        Job.DisplayInfo(job2);

        Resume resumeOnJoe = new Resume();
        resumeOnJoe._name = "Joe Dohn";
        resumeOnJoe._jobs.Add(job1);
        resumeOnJoe._jobs.Add(job2);
        resumeOnJoe.DisplayJobsList();
    }
}