using System.Collections.ObjectModel;

namespace BlazorShop.Api.Model;

public class Category
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string IconCss { get; set; } = string.Empty;

    // 1-N relationship
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
