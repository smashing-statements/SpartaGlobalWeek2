namespace UnitTestLessonApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            string output = GetGreeting(timeOfDay);
            Console.WriteLine(output);
        }

        public static string GetGreeting(int timeOfDay)
        {

            if (timeOfDay >= 5 && timeOfDay <= 12)
            {
                return "Good morning!";
            }
            else if (timeOfDay > 12 && timeOfDay <= 18)
            {
                 return "Good afternoon!";
            }
            else
            {
                return "Good evening!";
            }

        }
    }
}