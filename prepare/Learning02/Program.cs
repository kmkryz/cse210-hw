using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Philadelphia Country Club";
        job1._jobTitle = "Golf Staff";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "New Country Motors";
        job2._jobTitle = "Business Development Representative";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Resume resume = new Resume();
        resume._name = "Kaitlyn-marie Kryzanski";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();


    }
}