namespace MyAPI.Models;

public class OrderDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string OrderCollectionName { get; set; } = null!;
}