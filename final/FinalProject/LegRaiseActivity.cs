// Derived class for LegRaise activity
public class LegRaiseActivity : Activity
{
            
    public LegRaiseActivity() : base("Led-Raise", "Lie down on your back amd put your hands beneath your hips for support; Then lift your legs up until they form a right angle with the floor. Slowly bring your legs back down and repeat the exercise. This activity will help strengthen you abs and legs")
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
                    Console.WriteLine("     Raise Legs Equally...");
                    Console.WriteLine();
                    Thread.Sleep(2400);
                    Console.WriteLine("     Bring them down...");
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
                    Console.WriteLine("     Raise Legs Equally...");
                    Console.WriteLine();
                    Thread.Sleep(1800);
                    Console.WriteLine("     Bring them down...");
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
                    Console.WriteLine("     Raise Legs Equally...");
                    Console.WriteLine();
                    Thread.Sleep(1200);
                    Console.WriteLine("     Bring them down...");
                    Thread.Sleep(800);
                    secondsRemaining -= 2;
                }

                    base.End();
                        break;
 
            }
            
        }
    }
}
