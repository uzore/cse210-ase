using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();


        string uName = PromptuName();
        int uNum    = PromptuNum();


        int squaredNumber = SquaredNumber(uNum);

        DisplayResult(uName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptuName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptuNum()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int fnum = int.Parse(Console.ReadLine());

        return fnum;
    }

    static int SquareNumber(int fnum)
    {
        int square = fnum * fnum;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}")
    }


}