// See https://aka.ms/new-console-template for more information
using GenericListOfTrainee.Models;

List<Trainee> trainees = new List<Trainee>();

Trainee ashik = new Trainee();
ashik.Name = "Ashik Aby Joy";
ashik.Location = "Nettor";

trainees.Add(ashik);

//Object Initialization
Trainee arjun = new Trainee()
{
    Name = "Arjun Akhilash",
    Location = "Kodunagloor"
};

trainees.Add(arjun);

foreach (var item in trainees)
{
    Console.WriteLine($"{item.Name} \t {item.Location}");
}
