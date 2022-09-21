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

            //Demo 2: Functions

            //PrintTimeToBirthday(182);

            int mark = 35;



        }

        public static void PrintTimeToBirthday(int days)
        {
            //write to console the weeks and days left

            int weeks = days / 7;
            int remainingDays = days % 7;

            Console.WriteLine(string.Format("There are {0} weeks and {1} days remaining until your birthday!", weeks, remainingDays));

        }

        public static bool ReturnTrueIfEven(int num) => (num % 2 == 0);

    }
}