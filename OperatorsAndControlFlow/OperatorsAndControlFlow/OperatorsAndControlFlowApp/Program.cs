using System.Diagnostics.Metrics;

namespace OperatorsAndControlFlowApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Demo 1: increment operators and numeric types

            /*

            int x = 5;
            int y = 2;

            //int a = x++;
            //int b = ++y;
            //int b = ++y;

            int c = x / y;
            int d = x % y;

            var dbl = 5.0;
            var divided = dbl / 2;

            //this will result as 2. 5 and 2 are both integers, 
            //order of precedence determines that assignment occurs
            //and then division
            double f = 5 / 2;

            */

            /*
            Demo 2: Functions

            PrintTimeToBirthday(182);
            */

            //int mark = 35;
            //if greater than or equal to 85, return "distinction" else:

            //Ternery operator
            //is this true?
            //if so,
            //if not,
            //var grade = mark >= 65 ? "Pass" : "Fail";

            //nested turnery operator
            //var gradeDistinction = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";

            //var gradeExample2 = mark >= 85 ? "Distinction" : (mark >= 65 ? "Pass" : "Fail");

            //swtiches

            /*
            switch (mark)
            {
                case >= 85:
                    grade = "Distinction";
                    break;
                case >= 65:
                    grade = "Pass";
                    break;
                default:
                    grade = "Fail";
                    break;
            }
            */

            //Iterations

            List<int> nums = new List<int> { 10, 6, 22, -17, 3 };
            List<int> nums2 = new List<int> { -10, -6, -22, -17, -3 };

            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest for- loop: " + LoopTypes.HighestForLoop(nums));
            Console.WriteLine("Highest while- loop: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));

            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums2));
            Console.WriteLine("Highest for- loop: " + LoopTypes.HighestForLoop(nums2));
            Console.WriteLine("Highest while- loop: " + LoopTypes.HighestWhileLoop(nums2));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums2));

        }

        /*
        public static void PrintTimeToBirthday(int days)
        {
            //write to console the weeks and days left

            int weeks = days / 7;
            int remainingDays = days % 7;

            Console.WriteLine(string.Format("There are {0} weeks and {1} days remaining until your birthday!", weeks, remainingDays));

        }
        */

        //public static bool ReturnTrueIfEven(int num) => (num % 2 == 0);



        /*
        public static string Priority(int level)
        {​​
            string priority = "Code ";

            switch (level)
            {
                case 3:
                    priority = priority + "Red";
                    //this would be the same and would run without the break statement
                    //return priority + "Red";
                    break;
                case 2:
                    //blank cases will fall underneath. 2 will run 1
                case 1:
                    priority = priority + "Amber";
                    break;
                case 0:
                    priority = priority + "Green";
                    break;
                default:
                    priority = "Error";
                    break;
            }
            return priority;
        }​​


        */
    }
}