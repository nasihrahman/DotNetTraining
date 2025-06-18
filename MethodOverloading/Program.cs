namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Hello());
            Console.WriteLine(Hello("Akhil"));
        }
        public static string Hello()
        {
            return "Hello Shalvin";
        }
        public static string Hello(string name)
        {
            return $"Hello {name}";
        }
    }
}
