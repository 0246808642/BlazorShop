using BlazorShop.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorShop.Api.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Description).HasMaxLength(255);

            builder.Property(c=>c.ImageUrl).HasMaxLength(255);

            builder.Property(c=>c.Price).IsRequired().HasPrecision(10,2);
        }
    }
}
