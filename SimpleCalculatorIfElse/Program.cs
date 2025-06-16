int i, j, res = 0;
string oper;

Console.Write("Value 1 : ");
i  = Int32.Parse(Console.ReadLine());

Console.Write("Value 2 : ");
j = Int32.Parse(Console.ReadLine());

Console.Write("Enter operator (+, -) : ");
oper = Console.ReadLine();

if (oper == "+")
{
    res = i + j;
}
else if (oper == "-")
{
    res = i - j;
}
else
{
    Console.WriteLine("I don't know");
}
    Console.WriteLine(res);