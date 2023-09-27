using System;

public class Resume
{
    public string _name;

    // initialize list to a new List before using
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            // call display method on each job
            job.Display();
        }
    }
}