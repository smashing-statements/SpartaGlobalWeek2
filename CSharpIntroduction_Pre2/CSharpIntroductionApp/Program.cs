namespace CSharpIntroductionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //PascalCase for methods and classes
            //fields--variables--use camelCase
            //private field _numPrivate

            int x = 100;

            x += 10;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i: " + i + " x: " + x);
                x += i;
            }

            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }

        }
    }
}