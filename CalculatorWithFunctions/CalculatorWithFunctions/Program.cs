namespace CalculatorWithFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(45, 23));
            Console.WriteLine(Subtract(45, 23));
        }

        public static int Add(int i, int j)
        {
            return i + j;
        }
        public static int Subtract(int i, int j)
        {
            return i - j;
        }
    }
}
