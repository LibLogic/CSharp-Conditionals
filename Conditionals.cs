using System;

namespace CSharpFundamentals
{
    public class Conditionals
    {
        public static string IsValid()
        {
            Console.WriteLine("Please enter a number 1 -10");
            int num = int.Parse(Console.ReadLine());

            return num > 0 && num < 11 ? "Valid" : "Invalid";
        }

        public static int DisplayMax()
        {
            while (true)
            {
                Console.WriteLine("Enter a number 1 - 10");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter another  number 1 - 10");
                int b = int.Parse(Console.ReadLine());

                if (a > 0 && a < 11 && b > 0 && b < 11)
                {
                    Console.Clear();
                    return Math.Max(a, b);
                }
                Console.WriteLine("Enter only numbers 1 - 10 please");
            }
        }

        public static string Orientation()
        {
            Console.WriteLine("Please enter the width of your image");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height of your image");
            float height = float.Parse(Console.ReadLine());

            return width <= height ? "Portrait" : "Landscape";
        }

        public static string SpeedTrap()
        {
            Console.WriteLine("Please enter the speed limit \"0 - 200 MPH\"");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the detected speed");
            int speedDifference = int.Parse(Console.ReadLine()) - speedLimit;

            int demerit = speedDifference / 5;
            if (demerit <= 12 && demerit > 0)
            {
                return demerit.ToString();
            }
            return demerit > 0 ? "License Suspended" : "ok";
        }
    }

}