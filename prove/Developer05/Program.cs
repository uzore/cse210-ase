using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;

namespace Questor
{
    class Program
    {
        public static int score { get; set; }
        public static List<Quest> Quests{ get; set; }

        static void Main(string[] args)
        {
            score = 0;
            Quests = new List<Quest>();
            
            
            // LongTermQuest  quest = new LongTermQuest();
            Quests.Add(new SimpleQuest("Run a marathon", 1000));
            Quests.Add(new LongTermQuest("Read scriptures", 100));
            Quests.Add(new ChecklistQuest("Attend the temple", 50, 10));

            while(true)

            {
                Console.WriteLine("Current score: " + score);
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. View goals");
                Console.WriteLine("2. Add new goal");
                Console.WriteLine("3. Record event");
                Console.WriteLine("4. Save progress");
                Console.WriteLine("5. Load progress");
                Console.WriteLine("6. Exit");
                Console.WriteLine();

                Console.Write
                ("Enter menu option: ");
            }

        }
    }   
}