namespace BlazorShop.Api.Model;

public class Product
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public decimal Price { get; set; } 
    public int Amount { get; set; }

    // Foreign Key
    public long CategoryId { get; set; }
    
    // Navigation property
    public Category? Category { get; set; }

    // 1:N relationship
    public ICollection<CarItem> CarItems { get; set; } = new List<CarItem>();

}
