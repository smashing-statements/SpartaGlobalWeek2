namespace MemoryDemoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 7;

            Console.WriteLine(x);
            Console.WriteLine(y);

            Swap(ref x, ref y);

            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        private static void Swap(ref int x, ref int y)
        {
            /*
            int xVal = x;
            int yVal = y;

            y = xVal;
            x = yVal;
            */

            // can also use a tuple for this
            //it temporarily creates an anonymous object
            (y, x) = (x, y);

        }
    }
}