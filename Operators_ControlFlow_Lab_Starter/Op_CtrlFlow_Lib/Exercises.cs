using System;
using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {

            double total = 0;

            if (nums.Count != 0)
            {

                foreach (var item in nums)
                {
                    total += item;
                }

                total /= nums.Count;

            }
            else
            {
                throw new ArgumentOutOfRangeException("Please submit a non-empty array");

            }

            return total;

        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;

            switch (age)
            {
                case < 0:
                    throw new ArgumentOutOfRangeException("Age must be at least 0");
                case < 5:
                    return "Free";
                case < 13:
                    return "Child";
                case < 18:
                    return "Student";
                case < 60:
                    return "Standard";
                case >= 60:
                    return "OAP";
            }

        }

        public static string Grade(int mark)
        {
            /*
            switch (mark)
            {
                case < 0:
                    throw new ArgumentOutOfRangeException("Mark: " + mark + " Allowed range 0-100");
                case <= 39:
                    return "Fail";
                case <= 59:
                    return "Pass";
                case <= 74:
                    return "Pass with Merit";
                case <= 100:
                    return "Pass with Distinction";
                case > 100:
                    throw new ArgumentOutOfRangeException("Mark: " + mark + " Allowed range 0-100");
            }
            */
            if (mark >= 0 && mark <= 100)
            {
                if (mark <= 39)
                {
                    return "Fail";
                } 
                else if (mark <= 59)
                {
                    return "Pass";
                }
                else if (mark <= 74)
                {
                    return "Pass with Merit";
                }
                else
                {
                    return "Pass with Distinction";
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Mark: " + mark + " Allowed range 0-100");
            }

        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            switch (covidLevel)
            {
                case < 0:
                    throw new ArgumentOutOfRangeException("Mark: " + covidLevel + " Allowed range 0-4");
                case 0:
                    return 200;
                case 1:
                    return 100;
                case 2:
                    return 50;
                case 3:
                    return 50;
                case 4:
                    return 20;
                case > 4:
                    throw new ArgumentOutOfRangeException("Mark: " + covidLevel + " Allowed range 0-4");
            }
        }
    }
}
