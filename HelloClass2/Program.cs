namespace HelloClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Hello hello = new Hello();
            Console.WriteLine(hello.SayHello());
            Console.WriteLine(hello.SayHelloName("Anjana"));
        }
    }
}
