using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models.DTOs;

public class CartShopAddDto
{
    [Required]
    public long CartShopId { get; set; }

    [Required]
    public long ProductId { get; set; }

    [Required]
    public int Quantity { get; set; }
}
