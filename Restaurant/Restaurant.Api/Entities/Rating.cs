namespace Restaurant.Api.Entities;

public class Rating
{
    public int RatingID { get; set; }
    public int Score { get; set; }
    public string Notes { get; set; }

    // Foreign keys
    public int EmployeeID { get; set; }
    public int MealID { get; set; }

    // Navigation properties
    public Employee Employee { get; set; }
    public Meal Meal { get; set; }
}
