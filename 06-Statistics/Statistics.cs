[assembly: CLSCompliant(true)]
namespace WP01
{
    public static class Statistics
    {
        public static double Max(double value1, double value2)
        {
           if( value1< value2)
                return value2;
            else
                return value1;
        }

        public static double Min(double value1, double value2)
        {
           if( value1< value2)
                return value1;
            else
                return value2;
        }


        static void Main(string[] args)
        {
           
        }
    }
}
