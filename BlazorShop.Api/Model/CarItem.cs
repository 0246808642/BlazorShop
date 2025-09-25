namespace BlazorShop.Api.Model;

public class CarItem
{
    public long Id { get; set; }
    public long CartShopId { get; set; }
    public long ProdutoId { get; set; }
    public int Quantity { get; set; }

    // Navigation properties
    public CartShop? CartShop { get; set; }
    public Product? Product { get; set; }
}
