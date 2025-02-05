namespace Restaurant.Api.Entities;

public class Order
{
    public int OrderID { get; set; }
    public DateTime OrderTime { get; set; }
    public string Status { get; set; } // Pending, Accepted, In-Progress, Ready, Cancelled, Completed
    public string Notes { get; set; }

    // Foreign keys
    public int EmployeeID { get; set; }
    public int MealID { get; set; }

    // Navigation properties
    public Employee Employee { get; set; }
    public Meal Meal { get; set; }
}
