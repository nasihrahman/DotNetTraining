
using GenericListOfClassexpenses.Models;

List<Menu> menus = new List<Menu>()
{
    new Menu{Name = "Chicken Biriyani Full", Amount = 110},
    new Menu{Name = "Chicken Biriyani Half", Amount = 60 },
    new Menu{Name = "Meals", Amount = 40 }
};

foreach (var item in menus)
{
    Console.WriteLine($"{item.Name} \t {item.Amount}");
}
