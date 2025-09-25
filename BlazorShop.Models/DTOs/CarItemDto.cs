namespace BlazorShop.Models.DTOs;

public class CarItemDto
{
    public long Id { get; set; }
    public long CartShopId { get; set; }
    public long ProdutoId { get; set; }
    public int Quantity { get; set; }

    public string? ProductName { get; set; }
    public string? ProductDescription { get; set; }
    public string? ProductImageUrl { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPrice { get; set; }
}
