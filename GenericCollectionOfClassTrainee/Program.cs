
using GenericCollectionOfClassTrainee.Models;

List<Trainee> trainees = new List<Trainee>();

Trainee nathaniel = new Trainee
{
    Name = "Nathaniel",
    Location = "Kadavanthra",
    Points = 40
};

trainees.Add(nathaniel);

Trainee anjana = new Trainee
{
    Name = "Anjana",
    Location = "Malapuram",
    Points = 50
};

trainees.Add(anjana);

foreach (var item in trainees)
{
    Console.WriteLine($"{item.Name} \t {item.Location} \t {item.Points}");
}

