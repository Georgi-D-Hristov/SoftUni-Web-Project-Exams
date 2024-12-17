namespace DeskMarket.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;
        public string SellerId { get; set; } = null!;
        public IdentityUser Seller { get; set; } = null!;

        public DateTime AddedOn { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public IEnumerable<ProductClient> ProductsClients { get; set; } = new HashSet<ProductClient>();
    }
}
