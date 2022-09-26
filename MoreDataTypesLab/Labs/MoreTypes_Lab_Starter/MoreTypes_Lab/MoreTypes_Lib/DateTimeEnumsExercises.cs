using System;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {

            int age = date.Year - birthDate.Year;

            //if the birthday's month is greater than the date's
            //or if the birthday's month is the same as the date's,
            //and the month's day is greater than the birthdate
            if (date.Month < birthDate.Month || (date.Month == birthDate.Month && date.Day < birthDate.Day))
                age--;

            if (age <= 0)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }
            else
            {
                return age;
            }

        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            string year;
            string day;
            string month;

            year = date.Year.ToString().Substring(2);
            day = date.Day.ToString();

            switch(date.Month)
            {
                case 1:
                    month = "Jan";
                    break;
                case 2:
                    month = "Feb";
                    break;
                case 3:
                    month = "Mar";
                    break;
                case 4:
                    month = "Apr";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "Jun";
                    break;
                case 7:
                    month = "Jul";
                    break;
                case 8:
                    month = "Aug";
                    break;
                case 9:
                    month = "Sep";
                    break;
                case 10:
                    month = "Oct";
                    break;
                case 11:
                    month = "Nov";
                    break;
                case 12:
                    month = "Dec";
                    break;
                //strangely, this didn't work without a default case
                default:
                    month = "Never Reached";
                    break;
            }

            return (year + '/' + day + '/' + month);

        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            return string.Empty;
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            return string.Empty;
        }
    }
}
