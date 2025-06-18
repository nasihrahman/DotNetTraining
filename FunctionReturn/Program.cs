namespace FunctionReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Hello());
            Console.WriteLine(HelloName("Akhil"));
            Console.WriteLine(HelloNameLocation("Madhav", "Chottanikkara"));
        }
        public static string Hello()
        {
            return "Hello Shalvin";
        }

        public static string HelloName(string name)
        {
            return $"Hello {name}";
        }

        public static string HelloNameLocation(string name, string location)
        {
            return $"Hello {name}, located at {location}";
        }
    }
}
