namespace WP01
{
    public class Triangle
    {
        public static double CalcTriangleHyp(double a, double b)
        {
            return Math.Sqrt(a*a + b*b);
        }

        public static double CalcTriangleArea(double a, double b)
        {
            return (a*b)/2;
        }

        public static double CalcTriangleCirc(double a, double b)
        {
            return a+b+CalcTriangleHyp(a,b);
        }

        static void Main(string[] args)
        {
            
        }
    }
}