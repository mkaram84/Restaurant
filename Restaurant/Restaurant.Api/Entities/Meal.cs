namespace Restaurant.Api.Entities;

public class Meal
{
    public int MealID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int QuantityAvailable { get; set; }

    // Foreign key
    public int MenuID { get; set; }

    // Navigation properties
    public Menu Menu { get; set; }
    public IEnumerable<Ingredient> Ingredients { get; set; }
    public IEnumerable<Order> Orders { get; set; }
    public IEnumerable<Rating> Ratings { get; set; }
}
