public class BackwardLungeActivity : Activity
        {
            
            public BackwardLungeActivity() : base("Backward-Lunge", "This exercise eases the joint, core, and hamstrings. Stand with your feet shoulder apart and your hands on your hips. Take a big step backward with your right leg and lower your body until your left-thigh is parallel to the floor. Return and repeat with the other side")
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
                            Console.WriteLine("     Take a big step backward with your right leg and lower your body until your left-thigh is parallel to the floor...");
                            Console.WriteLine();
                            Thread.Sleep(2400);
                            Console.WriteLine("     Take a big step backward with your left leg and lower your body until your right-thigh is parallel to the floor...");
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
                            Console.WriteLine("     Take a big step backward with your right leg and lower your body until your left-thigh is parallel to the floor...");
                            Console.WriteLine();
                            Thread.Sleep(1800);
                            Console.WriteLine("     Take a big step backward with your left leg and lower your body until your right-thigh is parallel to the floor...");
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
                            Console.WriteLine("     Take a big step backward with your right leg and lower your body until your left-thigh is parallel to the floor...");
                            Console.WriteLine();
                            Thread.Sleep(1200);
                            Console.WriteLine("     Take a big step backward with your left leg and lower your body until your right-thigh is parallel to the floor...");
                            Thread.Sleep(800);
                            secondsRemaining -= 2;
                        }
                            base.End();
                                break;
                    }
            
                }
            }
        }