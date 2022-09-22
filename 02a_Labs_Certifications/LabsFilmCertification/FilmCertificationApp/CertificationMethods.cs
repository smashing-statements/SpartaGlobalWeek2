namespace FilmCertificationApp
{
    public class CertificationMethods
    {
        static void Main(string[] args)
        {
            
        }

        public static string AvailableClassifications(int ageOfViewer)
        {

            if (ageOfViewer < 0 || ageOfViewer > 150)
            {
                throw new ArgumentOutOfRangeException("Age: " + ageOfViewer + " Allowed age 0-150");
            }

            switch (ageOfViewer)
            {
                case (< 12):
                    return "U, PG & 12A films are available.";
                case (< 15):
                    return "U, PG, 12A & 12 films are available.";
                case (< 18):
                    return "U, PG, 12A, 12 & 15 films are available.";
                case (>= 18):
                    return "All films are available.";
            }
        }

    }
}