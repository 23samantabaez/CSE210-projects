using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2015;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Baker";
        job2._company = "Salvatore";
        job2._startYear = 2015;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Wilson Favela";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}