using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Developer";
        job1.startYear = 1994;
        job1.endYear = 1995;

        Resume resume = new Resume();
        resume._jobs.Add(job1);

        resume.displayJobs();


    }
}