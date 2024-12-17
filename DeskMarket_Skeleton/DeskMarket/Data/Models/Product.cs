namespace DeskMarket.Data.Models;

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Common.DataConstants;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ProductNameMaxLength)]
    public string ProductName { get; set; } = null!;

    [Required]
    [MaxLength(DescriptionMaxLength)]
    public string Description { get; set; } = null!;

    [Required]
    public decimal Price { get; set; }

    public string? ImageUrl { get; set; }

    [Required]
    [ForeignKey(nameof(Seller))]
    public string SellerId { get; set; } = null!;

    [Required]
    public IdentityUser Seller { get; set; } = null!;

    [Required]
    public DateTime AddedOn { get; set; }

    [Required]
    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }

    [Required]
    public Category Category { get; set; } = null!;

    public bool IsDeleted { get; set; } = false;

    public IEnumerable<ProductClient> ProductsClients { get; set; } = new HashSet<ProductClient>();
}
