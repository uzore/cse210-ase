using System;
using System.Collections.Generic;
using System.IO;

namespace Questor
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            
            bool done = false;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             Welcome to Questor!");
            Console.WriteLine("          Press [ENTER] to continue ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("     Please enter your name? ");
            string nom = Console.ReadLine();

            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"    Hey {nom}! What do you want to do with Questor today?");
                Console.WriteLine();
                Console.WriteLine("         1. New Quest ");
                Console.WriteLine("         2. Display Diary ");
                Console.WriteLine("         3. Save your entries to a file ");
                Console.WriteLine("         4. Load entries from a file ");
                Console.WriteLine("         5. Quit Questor ");
                Console.WriteLine();
                Console.WriteLine($"     {nom}, kindly choose a number from the above options: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.AddEntry();
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        done = true;
                        break;
                    default:
                        Console.WriteLine(" Invalid option!. Please choose any number from the 1-4 or 5 to [QUIT] Diary.");
                        break;
                }
            }
        }
    }
}   





