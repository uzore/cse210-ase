using System;

class Program
{
    static void Main(string[] args)
    {
        //create a base "Assignment" object
        Assignment a1 = new Assignment("Okwu Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignment
        MathAss a2 = new MathAss("Roberto Temi", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        // WriteAss a3 = new WriteAss("JoE Waters", "European", "The Causes of World War II");
        // Console.WriteLine(a3.GetSummary());
        // Console.WriteLine(a3.GetWritingInformation());
    }
}