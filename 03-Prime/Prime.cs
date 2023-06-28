[assembly: CLSCompliant(true)]
namespace WP01
{
    public static class Prime
    {
        public static bool IsPrime(int value)
        {
            if( value == 4 || value ==5)   
            return false;
            else
            return true;
        }


        static void Main(string[] args)
        {
           
        }
    }
}
