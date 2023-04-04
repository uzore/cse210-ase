using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;

namespace Questor
{
    class Program
    {
        //List of all goals
        public static List<Quest> quests = new List<Quest>();
        private static int score = 0;
        static void Main(string[] args)
        {
             bool done = false;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             Welcome to Questor!");
            Console.WriteLine("          Press [ENTER] to continue ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("     Please enter your name? ");
            string nom = Console.ReadLine();
            while(!done)

            {   
                Console.WriteLine($"    Hey {nom}! What do you want to do with Questor today?");
                Console.WriteLine();
                Console.WriteLine($"    Your current score is {score}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     1. Create a new quest");
                Console.WriteLine("     2. List Quest(s)");
                Console.WriteLine("     3. Save Quest");
                Console.WriteLine("     4. Load Quest Completed");
                Console.WriteLine("     5. Record Event");
                Console.WriteLine("     6. Exit");
                Console.WriteLine();
                 Console.WriteLine($"     {nom}, kindly choose a number from the above options: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        NewQuest();
                        break;
                    case "2":
                        ListQuest();
                        break;
                    case "3":
                        RecordEvent();
                        break;
                    case "4":
                        SaveQuest();
                        break;
                    case "5":
                        LoadQuests();
                        break;
                    case "6":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("  Invalid option!. Please choose any number from the 1-4 or 5 to [QUIT] Diary.");
                        break;
                }
            }

        }

        public static void NewQuest()
        {

             bool done = false;

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            while(!done)
            {
                Console.WriteLine("     A. CheckList Quest");
                Console.WriteLine("     B. Simple Quest");
                Console.WriteLine("     C. Long Term Quest");
                Console.WriteLine("     X. Main Menu");

                Console.WriteLine($"    Kindly choose from [A,B, C,] or [X] to go to the main menu: ");
                string type = Console.ReadLine();


                
                ChecklistQuest cQuest = new ChecklistQuest(name, 10, 20 );
                SimpleQuest sQuest = new SimpleQuest(name, 50 );
                LongTermQuest lQuest = new LongTermQuest(name, 100);
                

                switch (type)
                {
                    case "A":
                        cQuest.GetStatus();
                        quests.Add(cQuest);
                        break;
                    case "B":
                        sQuest.GetStatus();
                        quests.Add(sQuest);
                        break;
                    case "C":
                        lQuest.GetStatus();
                        quests.Add(lQuest);
                        break;
                    case "X":
                        done=true;
                        break;
                    default:
                        Console.WriteLine("     Invalid option!. Please choose any number from the 1-4 or 5 to [QUIT] Diary.");
                        break;
                }

            }

        }

        //List Quests
        public static void ListQuest()
        {
            Console.Clear();
            Console.WriteLine("     List of Quests");
            if (quests.Count == 0)
                {
                    Console.WriteLine("    No Quests found");
                }
            else
            {
                foreach(var quest in quests)
                {
                    Console.WriteLine(quest.GetStatus());
                }

                Console.ReadLine();

            }
        }

        public static void RecordEvent()
        {
            Console.Clear();
            Console.WriteLine("     Record an Event");

            if (quests.Count == 0)
            {
                Console.WriteLine("     No quests found");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("     Select a quest to record an event for: ");
            for (int i = 0; i < quests.Count; i++)
            {
                Console.WriteLine($"{i+1}. {quests[i].GetStatus()}");
            }

            Console.WriteLine($"{quests.Count+1}. Cancel");
            Console.WriteLine();
            Console.Write("     Enter your choice: ");

            string option = Console.ReadLine();

            if (int.TryParse(option, out int questIndex))
            {
                if(questIndex >= 1 && questIndex <= quests.Count)
                {
                    Quest quest = quests[questIndex-1];
                    if (quest.IsComplete)
                    {
                        Console.WriteLine("  Quest is already completed");
                    }
                    else
                    {
                        quest.IsComplete = true;
                        score += quest.value;
                        Console.WriteLine("     Event Recorded Successfully! ");
                    }
                
                    return;
                }
                
            }
            else if (option ==$"{quests.Count+1}")
            {
                return;
            }

            Console.WriteLine("     Invalid choice, try again...");
        }

        public static void SaveQuest()
        {
            Console.WriteLine("    Give the file a name:  ");
            string filename = Console.ReadLine();
            StreamWriter writer = new StreamWriter(filename);
            foreach (var quest in quests)
            {
                writer.WriteLine($"     {quest.Date.ToShortDateString()}|{quest.name}|{quest.score}");
            }
            writer.Close();
        }

        public static void LoadQuests()
        {
            Console.WriteLine("     Enter a filename:  ");
            string filename = Console.ReadLine();
            StreamReader reader = new StreamReader(filename);
            quests.Clear();
            while(!reader.EndOfStream)
            {
                string[] fields = reader.ReadLine().Split('|');
                DateTime date = DateTime.Parse

                (fields[0]);
                string name = fields[1];
                string value = fields[2];
                foreach(var quest in quests)
                {
                    quests.Add(quest);
                }

                reader.Close();

            }
        }
    }
}