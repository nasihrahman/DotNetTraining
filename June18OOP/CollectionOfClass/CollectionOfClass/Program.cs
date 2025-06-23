using CollectionOfClass.Models;

List<Contact> contacts = new List<Contact>()
{
    new Contact { Name = "Alice", Location = "New York" },
    new Contact { Name = "Bob", Location = "Los Angeles" },
    new Contact { Name = "Charlie", Location = "Chicago" }
};

foreach (var item in contacts)
{
    Console.WriteLine(item.Name + " - " + item.Location);
}