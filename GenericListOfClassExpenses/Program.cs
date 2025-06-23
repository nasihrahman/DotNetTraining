using GenericListOfClassExpenses.Models;

List<Menu> menus = new List<Menu>
{
    new Menu { name = "Chicken Biriyani", Price =110},
    new Menu { name = "Chicken Biriyani", Price = 50 }
};
foreach(var menu in menus)
{
    Console.WriteLine($"{menu.name} - Rs.{menu.Price}");
}

