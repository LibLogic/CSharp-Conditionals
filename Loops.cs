using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentals
{
    public class Loops
    {
        public static int DivByThree()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int SumInputs()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter some numbers, preess \"ok\" when done.");
                string input = Console.ReadLine();
                if (input == "ok")
                {
                    return sum;
                }
                sum += int.Parse(input);
            }
        }

        public static int CalculateFactorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i < num; i++)
            {
                factorial = factorial * (i + 1);
            }
            return factorial;
        }

        public static string GuessNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 10);
            int x = 0;
            while (x < 4)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    return "You won";
                }
                x++;
            }
            return "You lost";
        }

        public static int DisplayMaxNumber(string nums)
        {
            int max = 0;
            string[] numsArray = nums.Split(',' );
            for (int i = 0; i < numsArray.Length; i++)
            {
                if(Convert.ToInt32(numsArray[i]) > max)
                {
                    max = Convert.ToInt32(numsArray[i]);
                }
            }

            return max;
        }
    }
}