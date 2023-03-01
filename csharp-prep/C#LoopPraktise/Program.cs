using System;

class Program
{
    static void Main(string[] args)
    {
        string ans = "ok";
        while (ans == "ok")
        {
            Console.WriteLine("Enter [ok] to start game  ");
            ans = Console.ReadLine();
        }

        string response;

        do
        {
            Console.Write("Do you wish to start again? ");
            response = Console.ReadLine();
        } while (response == "yes");


        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
    }
}