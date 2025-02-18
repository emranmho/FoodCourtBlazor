using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodCourtBlazor.Data;

public class Product
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Please enter name..")]
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? SpecialTag { get; set; }
    [Range(0.01, 1000, ErrorMessage = "Price must be between 0.01 and 1000")]
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public Guid CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }
    public int? AvailableQuantity { get; set; }
    public bool? IsAvailable { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
    // public string CreatedBy { get; set; }
    // public string UpdatedBy { get; set; }
}