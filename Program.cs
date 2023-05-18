namespace Simpson
{
    internal class Program
    {
        public static double TrapezoidalRule(Func<double, double> f, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = f(a) + f(b);
            for (int i = 1; i < n; i++)
            {
                sum += 2 * f(a + i * h);
            }
            return sum * h / 2;
        }
        public static double Simpson(Func<double, double> f, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = f(a) + 4 * f((a + b) / 2) + f(b);
            return sum * h / 3;
        }
        static void Main(string[] args)
        {
            double integral = Simpson(x => x * x, 2, 3, 100);
            Console.WriteLine(integral);
        }
    }
}