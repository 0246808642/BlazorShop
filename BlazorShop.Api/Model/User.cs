namespace BlazorShop.Api.Model;

public class User
{
    public long Id { get; set; }
    public string NameUser { get; set; } = string.Empty;

    // Navigation property
    public CartShop? CartShop { get; set; }
}
