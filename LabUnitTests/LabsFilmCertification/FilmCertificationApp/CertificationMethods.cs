namespace FilmCertificationApp
{
    public class CertificationMethods
    {
        static void Main(string[] args)
        {
            
        }

        public static string GetClassification(int age)
        {

            switch(age)
            {
                case (< 12):
                    return "U, PG & 12 films are available.";
                case (< 15):
                    return "U, PG, 12 & 15 films are available.";
                case (< 18):
                    return "U, PG, 12, 15 & 18 films are available.";
                default:
                    return "Invald age given";
            }
        }

    }
}