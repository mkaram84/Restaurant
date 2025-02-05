namespace Restaurant.Api.Entities;

public class Report
{
    public int ReportID { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    // Foreign key
    public int AdminID { get; set; }

    // Navigation properties
    public Admin Admin { get; set; }
    public IEnumerable<Order> Orders { get; set; }
}
