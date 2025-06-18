namespace WithoutTopLevelStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Hello();
            Hello();

            HelloName("Akhil");
            HelloName("Madhav");
            HelloNameLocation("Akhil", "Mulanthuruthy");
        }

        public static void Hello()
        {
            Console.WriteLine("Hello Shalvin");
        }
        public static void HelloName(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        public static void HelloNameLocation(string name, string location)
        {
            Console.WriteLine($"Hello {name}, located at {location}");
        }
    }
}
