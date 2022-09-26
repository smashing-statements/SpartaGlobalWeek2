using System.Text;

namespace MemoryDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sahil = 5;

            int mark = sahil;

            mark++;

            int[] nums = { 1, 2, 3 };

            StringBuilder ameer = new StringBuilder("Ameer");

            StringBuilder cesar = ameer;

            ameer.Append("Gardezi");

            string tudor = "Umbreon";
            string[] will;

            {
                var lewis = 3.14159;
                string[] rahul = { "Jai", "Eevee", "Vaporeon" };
                tudor = rahul[1];
                will = rahul;
                rahul[0] = "Rahul";
            }

            //here, Rahul will stay in the heap because it's being
            //referenced by will who never leaves scope
            //remember will AND rahul are reference types
            Console.WriteLine(will);

            var nathan = SomeMethod(will, sahil);

            double adamReed;
            var success = Double.TryParse(tudor, out adamReed);
            Console.WriteLine(adamReed);

            bool rob = PassByRef(ref adamReed);
        }

        private static bool PassByRef(ref double pirate)
        {
            pirate *= 2;
            return true;
        }

        private static int SomeMethod(string[] connor, int max)
        {
            max--;
            connor[0] = "Connor";
            return max;
        }
    }
}