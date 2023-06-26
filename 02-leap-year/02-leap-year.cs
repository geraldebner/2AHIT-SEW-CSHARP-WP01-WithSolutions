namespace WP01
{
    public class leapYear
    {
        public static bool leap_year(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            leap_year(2000);
        }
    }
}
