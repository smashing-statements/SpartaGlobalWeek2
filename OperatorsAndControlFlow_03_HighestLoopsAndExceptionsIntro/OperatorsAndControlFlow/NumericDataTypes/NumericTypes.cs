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

            int numCows = 260;
            uint countCows = (uint)numCows;
            //below returns it as 4
            //256 is byte max so it overflows
            //Overflows go straight from 256 to 0
            byte byteCows = (byte)numCows;

            int bankBalance = -2;
            //This returns a very high number
            //almost highest poss value for uint
            uint posBalance = (uint)bankBalance;

            //Printing to binary actually prints these the same
            //for some reason?
            //Console.WriteLine(Convert.ToString(bankBalance, 2));
            //Console.WriteLine(Convert.ToString(posBalance, 2));

            //Console.WriteLine(Convert.ToString(numCows, 2));
            //Console.WriteLine(Convert.ToString(byteCows, 2));

            //You cannot case to and from certain field types
            //float pi = 3.14f;
            //bool boolPi = (bool)pi;
            //DateTime piDay = (DateTime)pi;

            //The Convert Class

            //var theInt = 5;
            //var anotherInt = Convert.ToInt32(theInt);

            //safe - widening

            //var myDouble = Convert.ToDouble(theInt);

            //narrowing (unsafe) with no data loss

            //var myShort = Convert.ToInt16(theInt);
            double myPi = 3.14;
            //float floatPi = Convert.ToSingle(myPi);

            //unsafe conversions with loss of data
            //int myCows = 260;
            //byte myByteCows = Convert.ToByte(myCows);

            //int myBankBalance = -2;
            //uint myPosBalance = Convert.ToUInt32(myBankBalance);

            //invalid
            //DateTime piDay = Convert.ToDateTime(myPi);

            int myFive = Convert.ToInt32("5");

            byte num = Byte.MaxValue;
            Console.WriteLine("Byte max: " + num);
            num += 1;
            Console.WriteLine(num);

        }
    }
}