using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");

        // Job1
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2022;

        job1.Display();

        // Job2
        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Project Manager";
        job2._startYear = 2022;
        job2._endYear = 2025;

        job2.Display();

        //Resume
        Resume myResume = new Resume();
        myResume._name = "Antony Ochieng";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}