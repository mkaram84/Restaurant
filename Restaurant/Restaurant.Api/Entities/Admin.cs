namespace Restaurant.Api.Entities;

public class Admin
{
    public int AdminID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    // Navigation properties
    public IEnumerable<Report> Reports { get; set; } = new List<Report>();
}
