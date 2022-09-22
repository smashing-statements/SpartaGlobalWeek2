using System.Collections.Generic;

namespace NumericDataTypes
{
    internal class NumericTypes
    {
        static void Main(string[] args)
        {

            int anInt = 3; //explicitly typed
            var vInt = 3; //implicitly typed
            var v2Int = vInt; //implicitly typed

            var name = "Cathy";
            var isClean = true;
            var letter = 'P';
            var uLongNum = 52uL;

            var prices = new List<decimal>();

            /*
            // Integer literals
            short n1 = -65;
            ushort n2 = 65;
            int n3 = -100_000;
            uint n4 = 100_000;
            uint n5 = 4_000_000_000;
            long n6 = -5_000_000_000;
            ulong n7 = 5_000_000_000;
            */

            /*

            // Integer literals
            var n1 = -65;
            var n2 = 65;
            var n3 = -100_000;
            var n4 = 100_000;
            var n5 = 4_000_000_000;
            var n6 = -5_000_000_000;
            var n7 = 5_000_000_000;

            //The binary form of 2/5 is fractionally lower than 2.4
            //these will produce different answers
            float sum = 0;
            for (int i = 0; i < 100_000; i++)
            { sum += 2 / 5.0f; }
            Console.WriteLine("2/5 added 100,000 times: " + sum);
            Console.WriteLine("2/5 multiplied by 100,000: " + 2 / 5.0f * 100_000);

            var result = 5.50 / 5;

            var myInt = 5;
            double myNum = myInt;

            //byte tooBig = 1000;

            */


            //byte  num = Byte.MaxValue;
            //Console.WriteLine("Byte max: " + num);
            //num += 1;
            //Console.WriteLine(num);

            double x = 3.14159265359;
            float y = (float)x;
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }
}