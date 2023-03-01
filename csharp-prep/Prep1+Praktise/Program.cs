class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.Write("Enter your school Identification Number: ");
        string ID = Console.ReadLine();

        Console.Write("What is your major? ");
        string major = Console.ReadLine();


        Console.WriteLine($"Your name is {last}, {first} {last} ");

        Console.WriteLine($"Here is your school ID: {ID} ");

        Console.WriteLine($"You're majoring in {major} ");

        Console.WriteLine($"{last}, You're welcome to Marriott Business School, Utah");

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