using System;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace MoreDataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region STRINGS

            /*

            var myString = "  C# list fundamentals ";
            //Console.WriteLine(StringExercise(myString));

            int scoreA = 2;
            int scoreB = 1;

            //Console.WriteLine(StringBuilderExercise(myString));

            string concatString1 = "Liverpool : " + scoreA + ", Manchester United : " + scoreB;
            string concatString2 = String.Concat("Liverpool : ", scoreA, ", Manchester United : ", scoreB);

            //StringInterpolation(myString);

            ParsingStrings();

            */

            #endregion

            #region ARRAYS

            int[] myIntArray = { 12, 23, 34, 45, 56 };
            Array.Reverse<int>(myIntArray);
            foreach (var element in myIntArray)
            {
                Console.WriteLine(element);
            }

            JaggedArrays();

            #endregion

        }

        #region ARRAY_METHODS

        public static void JaggedArrays()
        {
            // Jagged arrays
            int[][] intJArray = new int[2][];
            //first parameter must be declared because the minimum
            //the system must know is how many arrays there will be
            //independent of their length
            intJArray[0] = new int[4];
            intJArray[1] = new int[2];

            intJArray[0][2] = 3;
            intJArray[1][0] = 5;

            string[][] animalArray = new string[][]
            {
                new string[] { "llama", "puma", "horse", "kitten" },
                new string[] { "haddock", "tuna"}
            };

            foreach (var row in animalArray)
            {
                foreach (var element in row)
                {
                    Console.WriteLine(element);
                }
            }

        }

        public static void MultiDArrays()
        {
            //2D Arrays
            int[,] gridOG = new int[2, 4];
            gridOG[0, 1] = 6;
            gridOG[1, 0] = 8;
            gridOG[1, 3] = 10;

            char[,] gridTwo =
            {
                {'a', 'b' },
                {'c', 'd' },
                {'e', 'f' },
                {'g', 'h' }
            };

            int[,,] grid = new int[2, 4, 3];

        }

        #endregion

        #region STRING_METHODS

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

        #endregion
    }
}