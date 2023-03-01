using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int unum = -1;
        while (unum != 0)
        {
            Console.Write(" Type any number of your choice; enter [0] to quit  ");

            String useRes = Console.ReadLine();
            unum = int.Parse(useRes);


            if (unum != 0)
            {
                numbers.Add(unum);
            }
        }

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum of your inputs is {sum}");





            float ave = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average of your total input is: {ave}");


            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine($"Your maximum input is {max}");
    }
}