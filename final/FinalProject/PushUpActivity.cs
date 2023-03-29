        public class PushUpActivity : Activity
        {
            public PushUpActivity() : base("Push Up", "This activity works the chest, shoulders, triceps, back and legs. Lay prone to the ground with arms supporting your body then your body straight while raising and lowering your body with your arms.")
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
                            Console.WriteLine("     Push-Up...");
                            Console.WriteLine();
                            Thread.Sleep(2400);
                            Console.WriteLine("     Down...");
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
                            Console.WriteLine("     Push-Up...");
                            Console.WriteLine();
                            Thread.Sleep(1800);
                            Console.WriteLine("     Down...");
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
                            Console.WriteLine("     Push-Up...");
                            Console.WriteLine();
                            Thread.Sleep(1200);
                            Console.WriteLine("     Down...");
                            Thread.Sleep(800);
                            secondsRemaining -= 2;
                        }
                            base.End();
                                break;
                    }
            
                }
            }
        
        }