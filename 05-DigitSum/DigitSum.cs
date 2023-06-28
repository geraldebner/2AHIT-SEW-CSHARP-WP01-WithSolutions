[assembly: CLSCompliant(true)]
namespace WP01
{
    public static class DigitSum
    {
        public static int CalcDigitSum(int value)
        {
            int result = 0;
            while (value> 0) {
                result += value % 10; //letzte Ziffer zum Ergebnis addieren
                value /= 10; //letzte Ziffer von Zahl entfernen
            }
            return result;
        }


        static void Main(string[] args)
        {
           
        }
    }
}
