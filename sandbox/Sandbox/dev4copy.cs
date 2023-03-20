using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace Meditator
{
    
        static void Main(string[] args)
        {
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
                    Console.WriteLine($"Prepare to 5 seconds...");
                    Thread.Sleep(3000);
                }

                public void End()
                {
                    Console.WriteLine($"Awesome Job! You've completed {name} for {duration} seconds.");
                    Console.WriteLine($"Press ENTER to continue...");
                    Console.ReadKey();
                }
            }

            // Derived class for breathing activity
            class BreathingActivity : Activity
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
                        Console.WriteLine("Breathe in...");
                        Thread.Sleep(1000);
                        Console.WriteLine("Breathe out...");
                        Thread.Sleep(1000);
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
                        System.Threading.Thread.Sleep(10000);

                        // Keep prompting the user for items until the activity is over
                        int secondsRemaining = base.duration;

                        Console.WriteLine("You have {0} seconds to list as many items as you can.", duration);
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
                            Console.WriteLine("Stretch...");
                            Thread.Sleep(4000);
                            Console.WriteLine("Release...");
                            Thread.Sleep(4000);
                            secondsRemaining -= 2;
                    }

                    base.End();
                } 
        
        }
    }
}
