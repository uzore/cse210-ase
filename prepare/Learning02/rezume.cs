using System;

public class Rezume
{

    public string _name;

    //Make sure to initialize your list to a new List before you use it.
    public List <Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //Notice the use of the custom data type "Job" in the loop
        foreach (Job job in _jobs)
        {
            //This calls the Display method on each job
            job.Display();
        }
    }
}