public class PlankActivity : Activity
        {
            
            public PlankActivity() : base("Plank", "This exercise strengthens the abdomen, back and shoulders. Lie on the floor with your toes and forearms on the ground. Keep your body straight and hold this position as long as you can.")
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
                            Console.WriteLine("     Keep your body straight...");
                            Console.WriteLine();
                            Thread.Sleep(1200);
                            Console.WriteLine("     Hold this position...");
                            Thread.Sleep(800);
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
                            Console.WriteLine("     Keep your body straight...");
                            Console.WriteLine();
                            Thread.Sleep(1800);
                            Console.WriteLine("     Be Focussed...");
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
                            Console.WriteLine("     Keep your body Straight...");
                            Console.WriteLine();
                            Thread.Sleep(2400);
                            Console.WriteLine("     You're almost there...");
                            Thread.Sleep(1200);
                            secondsRemaining -= 2;
                        }
                            base.End();
                                break;
                    }
            
                }
            }
        }