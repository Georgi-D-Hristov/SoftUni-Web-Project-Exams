namespace DeskMarket.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ProductClient
    {
        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;


        public string ClientId { get; set; } = null!;

        public IdentityUser Client { get; set; } = null!;
    }
}
