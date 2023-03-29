public class ChestStretchActivity : Activity
        {
            public ChestStretchActivity() : base("Chest-Stretch", "To do this exercise find a doorway, take a lunge position in the doorway with your arms on the doorframe and your elbows a little lower than your shoulders, then slowly bring your chest forward. Hold this position for some seconds; then slowly come out of it, bring your arms down and do some shoulder rolls. Don't pull your head forward, and keep your neck relaxed")
            {
            }

            public void DoActivity()
            {
                bool done = false;
                while (!done)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("         DIFFICULTY LEVEL");
                    Console.WriteLine();
                    Console.WriteLine("         1. Simple");
                    Console.WriteLine("         2. Intermediate");
                    Console.WriteLine("         3. Extreme");
                    Console.WriteLine();
                    Console.WriteLine($"     Please choose any difficulty level to continue:");

                    string choice = Console.ReadLine();
    
                    if (choice == "1")
                    {    
                        base.Start();
                        int secondsRemaining = base.duration;

                        while (secondsRemaining > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("     Stay in the lunge position...");
                            Console.WriteLine();
                            Thread.Sleep(4000);
                            Console.WriteLine("     Release...");
                            Thread.Sleep(1000);
                            secondsRemaining -= 2;
                        }
                        base.End();
                            break;
                    }

                    else if (choice == "2")
                    {
                        base.Start();
                        int secondsRemaining = base.duration;

                        while (secondsRemaining>0)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("     Stay in the lunge position...");
                            Console.WriteLine();
                            Thread.Sleep(5000);
                            Console.WriteLine("     Release...");
                            Thread.Sleep(1000);
                            secondsRemaining -= 2;
                        }
                            base.End();
                                break;
                    }

                    else if  (choice == "3")
                    {
                        base.Start();
                        int secondsRemaining = base.duration;

                        while (secondsRemaining>0)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("     Stay in the lunge position...");
                            Console.WriteLine();
                            Thread.Sleep(6000);
                            Console.WriteLine("     Release...");
                            Thread.Sleep(1000);
                            secondsRemaining -= 2;
                        }
                            base.End();
                                break;
                    }
            
                }
            }
        }