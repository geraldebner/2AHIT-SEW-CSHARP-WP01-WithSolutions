
[assembly: CLSCompliant(true)]
namespace WP01
{
    public static class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            //return true;
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

        public static bool abc(int year)
        {
            
            return false;
        }

        static void Main(string[] args)
        {
            IsLeapYear(2000);
        }
    }
}
