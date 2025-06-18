// See https://aka.ms/new-console-template for more information
using ContactClass;

Console.WriteLine("Hello, World!");

Contact eldhose = new Contact()
{
    Name = "Eldhose",
    Location = "Kanjiramattom",
    Points = 70
};
Console.WriteLine($"{eldhose.Name} - {eldhose.Location} - {eldhose.Points}");
