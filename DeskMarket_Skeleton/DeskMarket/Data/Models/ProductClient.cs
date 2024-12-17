namespace DeskMarket.Data.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

[PrimaryKey(nameof(ProductId), nameof(ClientId))]
public class ProductClient
{
    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }

    public Product Product { get; set; } = null!;

    [ForeignKey(nameof(Client))]
    public string ClientId { get; set; } = null!;

    public IdentityUser Client { get; set; } = null!;
}
