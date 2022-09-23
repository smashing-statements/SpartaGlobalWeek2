using System.Diagnostics.SymbolStore;
using System.Runtime.Versioning;

namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = DoThis(10, "enthused");
            var result2 = DoThis(25);
            var pizza1 = OrderPizza(pineapple: true, anchovies: false);

            //tuples
            var myTuple = ("Joe", "Bloggs", 25);
            Console.WriteLine(myTuple);
            Console.WriteLine(myTuple.Item2);

            var myNamedTuple = (fName: "Jane", lName: "Doe", age: 32);
            Console.WriteLine(myNamedTuple);
            Console.WriteLine(myNamedTuple.lName);

            var title = "The Shining";
            int copies = 3;
            var myTuple3 = (title, copies);
            Console.WriteLine(myTuple3);
            Console.WriteLine(myTuple3.title);

            var weight = ConvertPoundsToStones(146);

        }

        public static int DoThis(int x, string y = "happy")
        {
            //WriteLine is static
            Console.WriteLine($"I'm feeling {y}");
            return x * x;
        }

        public static string OrderPizza(bool anchovies, bool pineapple, bool mushrooms = false)
        {
            var pizza = "Pizza with tomato sauce, cheese, ";
            if (anchovies) pizza += "anchovies, ";
            if (anchovies) pizza += "pineapple, ";
            if (anchovies) pizza += "mushrooms, ";
            return pizza;
        }

        public static (int stones, int pounds) ConvertPoundsToStones(int pounds)
        {
            const int poundsInAStone = 14;
            var st = pounds / poundsInAStone;
            var lbs = pounds % poundsInAStone;
            return (st, lbs);
        }
    }
}