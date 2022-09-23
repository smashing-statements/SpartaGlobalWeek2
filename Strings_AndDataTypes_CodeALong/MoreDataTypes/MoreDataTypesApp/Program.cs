using System;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace MoreDataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myString = "  C# list fundamentals ";
            //Console.WriteLine(StringExercise(myString));

            int scoreA = 2;
            int scoreB = 1;

            //Console.WriteLine(StringBuilderExercise(myString));

            string concatString1 = "Liverpool : " + scoreA + ", Manchester United : " + scoreB;
            string concatString2 = String.Concat("Liverpool : ", scoreA, ", Manchester United : ", scoreB);

            //StringInterpolation(myString);

            ParsingStrings();
        }

        public static void StringInterpolation(string str)
        {
            //Console.WriteLine("My name is : " + str + "using +");
            //Console.WriteLine($"My name is: {str} using interpolation");

            var num1 = 2;
            var num2 = 7;
            var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";

            //the below :#.0000 specifies print the integers to 3 decimal places
            var fString2 = $"Log to the base {num2} of {num1} is {Math.Log(num2, num1):#.000}";
            var fString3 = $"That will be {num2 / 3.0:C} please!";

            Console.WriteLine(fString2);
            Console.WriteLine(fString3);

        }

        public static void ParsingStrings()
        {
            //parsing strings
            Console.WriteLine("How many apples?");
            string input = Console.ReadLine();
            //int numApples = Int32.TryParse(input, out int parsedApples)
            var success = Int32.TryParse(input, out int parsedApples);
        }
    

        public static string StringExercise(string myString)
        {
            //Always put myString = before using the method
            myString = myString.Trim();
            myString = myString.ToUpper();
            myString = myString.Replace('L', '*');
            myString = myString.Replace('T', '*');

            //There is also a method called .LastIndexOf()
            int index = (myString.IndexOf("N") + 1);
            if (index > 0)
                myString = myString.Substring(0, index);

            return myString;

        }

        public static string StringBuilderExercise(string myString)
        {
            /*
            int index = myString.IndexOf('n') + 1;
            StringBuilder sb = new StringBuilder(myString);

            sb.Replace('l', '*')
              .Replace('t', '*')
              .Remove(index, myString.Length - index);

            return sb.ToString().Trim().ToUpper();
            */

            var trimmedUpperString = myString.Trim().ToUpper();
            var nPos = trimmedUpperString.IndexOf('N');
            StringBuilder sb = new StringBuilder(trimmedUpperString);
            sb.Replace('L', '*').Replace('T', '*').Remove(nPos + 1, sb.Length - nPos - 1);
            return sb.ToString();

        }
    }
}