public class JumpingJackActivity : Activity
        {
            
            public JumpingJackActivity() : base("Jumping-Jack", "This exercise provides a full-body workout and works all your large muscle groups. Start with your feet together and your arms by your sides, then jump up with your feet apart and your hands overhead.  Return to the start position then do the next round.")
            {
            }

            public void DoActivity()
            {
                bool done = false;
                while (!done)
                {
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
                            Console.WriteLine("     Widen your legs and hands...");
                            Console.WriteLine();
                            Thread.Sleep(2400);
                            Console.WriteLine("     Close...");
                            Thread.Sleep(1200);
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
                            Console.WriteLine("     Widen your legs and hands...");
                            Console.WriteLine();
                            Thread.Sleep(1800);
                            Console.WriteLine("     Close...");
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
                            Console.WriteLine("     Widen your legs and hands...");
                            Console.WriteLine();
                            Thread.Sleep(1200);
                            Console.WriteLine("     Close...");
                            Thread.Sleep(800);
                            secondsRemaining -= 2;
                        }
                            base.End();
                                break;
                    }
            
                }
            }
        }