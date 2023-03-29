using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;

namespace MindCare
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity reminder = new Activity("MindCare", "Any of these activities should help your mind!");
            bool done = false;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             Welcome to MindCare!");
            Console.WriteLine("        Respond to the prompt then, press [ENTER] to continue ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("          Please enter your name? ");
            string nom = Console.ReadLine();

            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"    Hello {nom}! What activity would you wantJoe to do with MindCare today?");
                Console.WriteLine();
                Console.WriteLine("         1. Do a Breathing-Activity");
                Console.WriteLine("         2. Do a Reflection-Activity");
                Console.WriteLine("         3. Do a Listing-Activity");
                Console.WriteLine("         4. Do a Stretching-Activity");
                Console.WriteLine("         5. Do a PushUp-Activity");
                Console.WriteLine("         6. EXIT MindCare!");
                Console.WriteLine();
                Console.WriteLine($"     {nom}, Kindly enter any number from [1-5] to try a MindCare activity or [6] to EXIT MindCare: ");

                BreathingActivity BAct = new BreathingActivity();
                ReflectionActivity ReflAct = new ReflectionActivity();
                ListingActivity ListAct = new ListingActivity();
                StretchingActivity StrAct = new StretchingActivity();
                PushUp PushAct = new PushUp();


                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BAct.DoActivity();
                        break;
                    case "2":
                        ReflAct.DoActivity();
                        break;
                    case "3":
                        ListAct.DoActivity();
                        break;
                    case "4":
                        StrAct.DoActivity();
                        break;
                    case "5":
                        PushAct.DoActivity();
                        break;
                    case "6":
                        done = true;
                        break;
                    default:
                        Console.WriteLine(" Invalid option!. Please make a choice.");
                        break;
                }
            }
        }

        public class Activity
        {
            private string name;
            private string description;
            protected int duration;
            public Activity(string name, string description)
            {
                this.name = name;
                this.description = description;
            }

            public void Start()
            {
                Console.WriteLine($"{name} - {description}");
                Console.Write("Enter duration in seconds:  ");
                duration = int.Parse(Console.ReadLine());
                Console.WriteLine($"Prepare to do {name} in 3 seconds...");
                Thread.Sleep(3000);

                List<string> aStrings = new List<string>();
                aStrings.Add("|");
                aStrings.Add("/");
                aStrings.Add("-");
                aStrings.Add("\\");
                aStrings.Add("|");
                aStrings.Add("/");
                aStrings.Add("-");
                aStrings.Add("\\");

                foreach (string s in aStrings)
                {
                    Console.Write(s);
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                }
            }

        
            public void End()
            {

                List<string> aStrings = new List<string>();
                aStrings.Add("|");
                aStrings.Add("/");
                aStrings.Add("-");
                aStrings.Add("\\");
                aStrings.Add("|");
                aStrings.Add("/");
                aStrings.Add("-");
                aStrings.Add("\\");

                foreach (string s in aStrings)
                {
                    Console.Write(s);
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Awesome Job! You've completed {name} for {duration} seconds.");
                Console.WriteLine();
                Console.WriteLine($"Press ENTER to continue...");
                Console.ReadKey();
            }
        }
    

        // Derived class for breathing activity
        public class BreathingActivity : Activity
        {
            
            public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
            {
            }

            public void DoActivity()

            {
                base.Start();
                int secondsRemaining = base.duration;

                while (secondsRemaining > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Breathe in...");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.WriteLine("Breathe out...");
                    Thread.Sleep(500);
                    secondsRemaining -= 2;
                }

                base.End();
            }
        }

        // Derived class for reflection activity
        public class ReflectionActivity : Activity
        {
            private string[] prompts = { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
            private string[] questions = { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

            public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
            {
            }

            public void DoActivity()
            {

                base.Start();
                int secondsRemaining = base.duration;

                while (secondsRemaining > 0)
                {

                    string prompt = prompts[new Random().Next(prompts.Length)];
                    Console.WriteLine(prompt);
                    Thread.Sleep(1000);

                    foreach (string question in questions)
                    {

                        Console.WriteLine(question);
                        Thread.Sleep(2000);
                    }

                    secondsRemaining -= (prompts.Length * questions.Length * 2);
                }

                base.End();

            }
        }



        // Derived class for listing activity
        public class ListingActivity : Activity
        {
            private string[] prompts = { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
            private List<string> items = new List<string>();

            public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
            {

            }
            public void DoActivity()
            {
                base.Start();

                // Select a random prompt
                Random rnd = new Random();
                int promptIndex = rnd.Next(prompts.Length);
                string prompt = prompts[promptIndex];


                Console.WriteLine(prompt);

                // Prompt the user to start listing items
                Console.WriteLine("You have 10 seconds to start listing items.");
                System.Threading.Thread.Sleep(1000);

                // Keep prompting the user for items until the activity is over
                int secondsRemaining = base.duration;

                Console.WriteLine($"You have {duration} seconds to list as many items as you can.");
                System.Threading.Thread.Sleep(2000);

                while (secondsRemaining > 0)
                {
                    Console.Write("Enter an item: ");
                    string item = Console.ReadLine();

                    if (!string.IsNullOrEmpty(item))
                    {
                        items.Add(item);
                    }
                }

                Console.WriteLine("You listed {0} items:", items.Count);

                // Print out the items that were entered
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, items[i]);
                }

                base.End();
            }



        }

        public class StretchingActivity : Activity
        {
            public StretchingActivity() : base("Stretching Activity", "This activity will help flex your muscle and ease blood circulation. Free your body and stretch yourself from the inside out.")
            {
            }

            public void DoActivity()
            {
                base.Start();
                int secondsRemaining = base.duration;

                while (secondsRemaining > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Stretch...");
                    Console.WriteLine();
                    Console.WriteLine();
                    Thread.Sleep(4000);
                    Console.WriteLine("Release...");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    secondsRemaining -= 2;
                }


                base.End();
            }
        }

        public class PushUp : Activity
        {
            public PushUp() : base("Push Ups", "This activity will help build your muscles, ease blood circulation and increase your stamina")
            {
            }

            public void DoActivity()
            {
                base.Start();
                int secondsRemaining = base.duration;

                while (secondsRemaining > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Push up...");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("Down...");
                    Console.WriteLine();
                    Thread.Sleep(2500);
                    secondsRemaining -= 2;
                }

                base.End();
            }
        
        }

    
    }
}        



