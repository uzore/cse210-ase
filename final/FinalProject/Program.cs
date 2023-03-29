using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;

namespace GetFit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                     Welcome to GetFit!");
            Console.WriteLine("         Respond to the prompt then, press [ENTER] to continue ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("          Please enter your name? ");
            string nom = Console.ReadLine();

            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"    Hello {nom}! What Exercise would you want to do with GetFit today?");
                Console.WriteLine();
                Console.WriteLine("         1. Treadmill Walk");
                Console.WriteLine("         2. Do Some Push-Ups");
                Console.WriteLine("         3. Do Some Jumping-Jacks");
                Console.WriteLine("         4. Do Plank Exercise");
                Console.WriteLine("         5. Do Chest-Stretch Exercise");
                Console.WriteLine("         6. Do Backward-Lunge Exercise");
                Console.WriteLine("         7. Do Squat Exercise");
                Console.WriteLine("         8. Do Leg-Raise Exercise");
                Console.WriteLine("         9. Do Sit-Ups");
                Console.WriteLine("         0. EXIT GetFit!");
                Console.WriteLine();
                Console.WriteLine($"     Kindly enter any number from [1-9] to try, record, and view your progress on any exercise of your choice or [0] to EXIT GetFit:  ");

                WalkingActivity WAct = new WalkingActivity();
                PlankActivity PAct = new PlankActivity();
                JumpingJackActivity JAct = new JumpingJackActivity();
                ChestStretchActivity StrAct = new ChestStretchActivity();
                PushUpActivity PushAct = new PushUpActivity();
                BackwardLungeActivity BAct = new BackwardLungeActivity();
                SquatActivity SqAct = new SquatActivity();
                LegRaiseActivity LAct = new LegRaiseActivity();
                SitUpActivity SupAct = new SitUpActivity();


                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WAct.DoActivity();
                        break;
                    case "2":
                        PushAct.DoActivity();
                        break;
                    case "3":
                        JAct.DoActivity();
                        break;
                    case "4":
                        PAct.DoActivity();
                        break;
                    case "5":
                        PushAct.DoActivity();
                        break;
                    case "6":
                        BAct.DoActivity();
                        break;
                    case "7":
                        SqAct.DoActivity();
                        break;
                    case "8":
                        LAct.DoActivity();
                        break;
                    case "9":
                        SupAct.DoActivity();
                        break;
                    case "0":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("     Invalid option!. Please make a choice.");
                        break;
                }
            }
        }
        
    }
}