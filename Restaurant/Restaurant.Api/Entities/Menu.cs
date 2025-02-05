namespace Restaurant.Api.Entities;

public class Menu
{
    public int MenuID { get; set; }
    public DayOfWeek DayOfWeek { get; set; }

    // Navigation properties
    public IEnumerable<Meal> Meals { get; set; }
}
