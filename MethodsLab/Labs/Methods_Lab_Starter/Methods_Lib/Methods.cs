using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays >= 0)
            {
                return (totalDays / 7, totalDays % 7);
            }
            else
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }

        }

        public static (int, int, double) PowersRoot(int num)
        {

            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("integer must not be negative");
            }
            else
            {

                int square = (num * num);
                int cube = square * num;
                double sqrRt = Math.Round(Math.Sqrt(num), 2);

                return (square, cube, sqrRt);

            }
        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

    }
}
