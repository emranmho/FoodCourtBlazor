using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodCourtBlazor.Data;

public class OrderCartDetails
{
    public Guid Id { get; set; }
    
    public Guid OrderCartId { get; set; }
    [ForeignKey("OrderCartId")]
    public OrderCart OrderCart { get; set; }
    
    public Guid ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
    
    [Required]
    public int Count { get; set; }
    
    [Required]
    public double Price { get; set; }
    
    public string ProductName { get; set; }
}