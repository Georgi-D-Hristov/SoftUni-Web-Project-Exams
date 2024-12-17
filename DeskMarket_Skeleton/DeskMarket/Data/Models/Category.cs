namespace DeskMarket.Data.Models;

using System.ComponentModel.DataAnnotations;
using static Common.DataConstants;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(CategoryNameMaxLength)]
    public string Name { get; set; } = null!;

    public IEnumerable<Product> Products { get; set; } = new HashSet<Product>();
}
