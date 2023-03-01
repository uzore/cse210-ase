using System;

class Program
{
    static void Main(string[] args)

    
    {   
        Console.WriteLine("Enter your name ");
        String name = Console.ReadLine(); 

        if (name == "Joseph" || name == "Nnachi" || name == "Otu")
        {
            Console.WriteLine("You are a student of BYU-Idaho");
        }

        else if(name == "Nnachi" && name == "Joseph" && name == "Otu")
        {
            Console.WriteLine("You are a BYU-Idaho Student");
        }
        else
        {
            Console.WriteLine("Information not found");
        }

        {
        Console.Write("What is your favorite number? ");
        string fnum = Console.ReadLine();
        int number = int.Parse(fnum);
        }
        {
            string fnum = number.ToString();
        }
    }
}