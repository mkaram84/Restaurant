namespace Restaurant.Api.Entities;

public class Configuration
{
    public int ConfigurationID { get; set; }
    public string ChefName { get; set; }
    public string ChefEmail { get; set; }
    public TimeSpan OrderStartTime { get; set; }
    public TimeSpan OrderEndTime { get; set; }
    public int LowQuantityThreshold { get; set; }
}