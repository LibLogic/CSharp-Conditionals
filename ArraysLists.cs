using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class ArraysLists
    {
        public static string PromptForNames()
        {
            var names = new List<string>();
            string name = "";
            string nameStr = "";

            while (true)
            {
                Console.WriteLine("Enter a friends name: ");
                name = Console.ReadLine();
                if (!String.IsNullOrEmpty(name))
                {
                    names.Add(name);
                } else
                {
                    break;
                }
            }

            if (names.Count == 1 || names.Count == 2 || names.Count == 3)
            {
                names.Add((names.Count).ToString());
                nameStr = string.Join(",", names);
                return nameStr;
            } else
            {
                return nameStr;
            }
        }

        public static string ReverseString()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            char[] nameArr = name.ToCharArray();
            Array.Reverse(nameArr);
            return new string(nameArr);
        }

        public static string FiveNumbers()
        {
            int count = 0;
            var numArr = new int[5];
            while (count < 5)
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (!numArr.Contains(num))
                {
                    numArr[count] = num;
                    count++;
                } else 
                {
                    Console.WriteLine("Duplicate number, try again: ");
                }

            }
            Array.Sort(numArr);
            return string.Join(",", numArr);
        }

        public static string UniqueNumbers() 
        {
            int count = 0;
            var numArr = new List<int>();
            while (true)
            {
                Console.Write("Enter a nmuber: ");
                string input = Console.ReadLine();
                if (input == "quit")
                {
                    List<int> newList = new List<int>();
                    newList = numArr.Distinct().ToList();

                    return string.Join(",", newList);

                } else
                {
                    int num = Convert.ToInt32(input);
                    numArr.Add(num);
                    count++;
                }
            }
        }

        public static string DisplaySmallestThree()
        {
            Console.Write("Enter a comma separated list of integers: ");
            string numList = Console.ReadLine();
            string[] newList = numList.Split(',');
            if (newList.Length == 0 || newList.Length < 5) 
            {
                Console.WriteLine("Invalid List");
                return "hello";
            }
            else
            {
               Array.Sort(newList);
               return string.Join(",", newList);
            }
        }
    }
}
