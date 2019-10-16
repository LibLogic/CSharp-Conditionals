using System;

namespace CSharpFundamentals
{
    public class Loops
    {
        public static int DivByThree()
        {
            int count = 0;
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
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
    }
}