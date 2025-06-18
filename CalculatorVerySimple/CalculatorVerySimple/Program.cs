namespace CalculatorVerySimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, result = 0;
            string oper;
            Console.Write("Value 1 :");
            i = Int32.Parse (Console.ReadLine());

            Console.Write("Value 2 : ");
            j = Int32.Parse (Console.ReadLine());

            Console.Write("Enter operator (+, -) : ");
            oper = Console.ReadLine ();
            if (oper == "+")
            {
                result = i + j;
            }
            else if (oper == "-")
            {
                result = i - j;
            }
            else if(oper == "*")
            {
                result = i * j;
            }
            else if(oper == "/")
            {
                result = i / j;
            }
                Console.WriteLine(result);
        }
    }
}
