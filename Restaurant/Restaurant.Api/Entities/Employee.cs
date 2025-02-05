namespace Restaurant.Api.Entities;

public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }

    // Navigation properties
    public IEnumerable<Order> Orders { get; set; }
    public IEnumerable<Rating> Ratings { get; set; }
}
