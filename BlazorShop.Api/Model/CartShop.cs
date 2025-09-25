namespace BlazorShop.Api.Model
{
    public class CartShop
    {
        public long Id { get; set; }
        public long UserId { get; set; }

        // 1:N relationship
        public ICollection<CarItem> CarItems { get; set; } = new List<CarItem>();

    }
}
