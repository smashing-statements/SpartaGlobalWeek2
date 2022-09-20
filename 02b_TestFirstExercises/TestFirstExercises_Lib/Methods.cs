﻿using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace TestFirstExercises
{
    public class Methods
    {
        // implement this method so that it returns true if x is greater than or equal to y
        public static bool GreaterEqual(int x, int y) => x >= y;

        // Implement this method so that it take an int as an input,
        // squares it, adds 101, divides the result by 7, then subtracts 4.  
        // Return a double rounded to 3 decimal places.
        public static double BODMAS(int inputNumber)
        {
            double inputDouble = Convert.ToDouble(inputNumber);

            inputDouble *= inputDouble;
            inputDouble += 101;
            inputDouble /= 7;
            inputDouble -= 4;

            inputDouble = Math.Round(inputDouble, 3);

            return inputDouble;
        }

        // implement this method so that it returns true if num is even, otherwise false
        public static bool EvenOdd(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }

        // implement this method so that it returns 
        // the sum of all numbers between 1 and n inclusive 
        // that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int total = 0;

            for (int i = 0; i < max + 1; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }
            return total;
        }

        // implement this method so it returns true if input is "password"
        // regardless of case
        public static bool CheckInput(string input)
        {
            return string.Equals(input, "password", StringComparison.CurrentCultureIgnoreCase);
        }

        // implement this method so it returns the sum
        // of all the numbers in the list
        public static int SumList(List<int> list)
        {
            int total = 0;

            foreach (int item in list)
            {
                total += item;
            }

            return total;
        }
    }
}