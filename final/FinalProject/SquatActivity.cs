// Derived class for Squat activity
public class SquatActivity : Activity
{
            
    public SquatActivity() : base("Squat", "Stand with your feet should width apart and your arms stretched forward, then lower your body until your thighs are parallel with the floor. Your knees should be extended in the same direction as your toes. Repeat the exercise.  This exercise works the thighs, hips buttocks, quads, hamstrings, and lower body")
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
                    Console.WriteLine("     Squat down...");
                    Console.WriteLine();
                    Thread.Sleep(2400);
                    Console.WriteLine("     Up...");
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
                    Console.WriteLine("     Squat down...");
                    Console.WriteLine();
                    Thread.Sleep(1800);
                    Console.WriteLine("     Up...");
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
                    Console.WriteLine("     Squat down...");
                    Console.WriteLine();
                    Thread.Sleep(1200);
                    Console.WriteLine("     Up...");
                    Thread.Sleep(800);
                    secondsRemaining -= 2;
                }

                    base.End();
                        break;
 
            }
            
        }
    }
}
