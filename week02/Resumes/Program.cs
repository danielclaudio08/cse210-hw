using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Account Associate";
        job1._company = "VXI Global Solutions, LLC";
        job1._startYear = 2022;
        job1._endYear = 2022;

        Job job2 = new Job();

        job2._jobTitle = "Team Lead";
        job2._company = "Melham Construction Corporation";
        job2._startYear = 2020;
        job2._endYear = 2021;

        Resume resume = new Resume();
        resume._givenName = "Ivy Pelayo";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();


    }
}