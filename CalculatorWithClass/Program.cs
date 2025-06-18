namespace CalculatorWithClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(34, 23));
            //Console.WriteLine(calculator.Subtract(34, 23));
            int x, y, result = 0;
            string oper;
            Console.Write("Value 1 : ");
            x = Int32.Parse(Console.ReadLine());

            Console.Write("Value 2 : ");
            y = Int32.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -) : ");
            oper = Console.ReadLine();

            if (oper == "+")
            {
                result = calculator.Add(x, y);
            }
            else if (oper == "-")
            {
                result += calculator.Subtract(x, y);
            }
                Console.WriteLine(result);
        }
    }
}
