using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage? ");
        string cgpa = Console.ReadLine();
        int grade = int.Parse(cgpa);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }
        
        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (grade >= 70)
        {
            Console.WriteLine("You Passed");
        }
        else
        {
            Console.WriteLine("You Failed! Better Luck Next Time");
        }

    }
}