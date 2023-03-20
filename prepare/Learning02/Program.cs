using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Managing Director";
        job1._coName = "Uxore";
        job1._startYear = 2025;
        job1._endYear = 2070;

        Job job2 = new Job();
        job2._jobTitle = "IT Support";
        job2._coName = "Otech Microfinance Bank Limited";
        job2._startYear = 2022;
        job2._endYear = 2025;

        Rezume cv = new Rezume();
        cv. _name = "Nnachi, Joseph";

        cv. _jobs.Add(job1);
        cv._jobs.Add(job2);

        cv.Display();

    }
    public class Job
    {
        public string _coName;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} {_coName} {_startYear}-{_endYear}");
        }


    }

     public class Rezume
    {
        public string _name;

    // Make sure to initialize your list to a new List before you use it.
        public List<Job> _jobs = new List<Job>();

        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");

            //Notice the use of the custom data type "Job" in this loop
            foreach (Job job in _jobs)
            {
                //This calls the Display method on each job
                job.Display();
            }
        }
    }
}