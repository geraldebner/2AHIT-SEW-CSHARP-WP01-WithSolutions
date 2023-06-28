[assembly: CLSCompliant(true)]
namespace WP01
{
    public static class Faculty
    {
        public static int CalcFaculty(int value)
        {
            int facult = 1;
            for (int i = 1;i<=value;i++)
            {
                facult *= i;
            }
            return facult;
        }


        static void Main(string[] args)
        {
           Console.WriteLine(CalcFaculty(10)+"\n");
           Console.WriteLine(CalcFaculty(30)+"\n");
           Console.WriteLine(CalcFaculty(100)+"\n");
        }
    }
}
