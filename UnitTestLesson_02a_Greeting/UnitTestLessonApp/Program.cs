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

            switch(timeOfDay)
            {
                case < 0:
                    throw new ArgumentOutOfRangeException("Your time is invalid. Please input a time between 0 and 24");
                case < 5:
                    return "Good evening!";
                case < 13:
                    return "Good morning!";
                case < 18:
                    return "Good afternoon!";
                case <= 24:
                    return "Good evening!";
                case > 24:
                    throw new ArgumentOutOfRangeException("Your time is invalid. Please input a time between 0 and 24");

            }

            /*
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
            */

        }
    }
}