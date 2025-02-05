namespace Restaurant.Api.Entities;

public class Ingredient
{
    public int IngredientID { get; set; }
    public string Name { get; set; }
    public int QuantityInStock { get; set; }

    // Foreign key
    public int MealID { get; set; }

    // Navigation properties
    public Meal Meal { get; set; }
}
