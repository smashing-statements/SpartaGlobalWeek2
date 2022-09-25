using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            string upped = input.ToUpper().Trim();
            StringBuilder sb = new StringBuilder(upped);

            for (int i = 0; i < num; i++)
            {
                sb.Append(i);
            }

            return sb.ToString();

        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(number + " " + street + ", " + city + " " + postcode + ".");

            return sb.ToString();

        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            decimal percent = ((decimal)score / (decimal)outOf)*100;
            string percent1Dp = percent.ToString("0.0");

            return $"You got {score} out of {outOf}: {percent1Dp}%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {

            try
            {
                return Convert.ToDouble(numString);
            }
            catch (FormatException)
            {
                return -999;
            }

            /*
            if (!Regex.IsMatch(numString, @"^[a-zA-Z]+$"))
            {
                return Convert.ToDouble(numString);
            }
            else
            {
                return -999;
            }
            */

        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int As = 0;
            int Bs = 0;
            int Cs = 0;
            int Ds = 0;

            foreach (char item in input)
            {
                switch(item)
                {
                    case 'A':
                        As++;
                        break;
                    case 'B':
                        Bs++;
                        break;
                    case 'C':
                        Cs++;
                        break;
                    case 'D':
                        Ds++;
                        break;
                }
            }

            return $"A:{As} B:{Bs} C:{Cs} D:{Ds}";

        }
    }
}
