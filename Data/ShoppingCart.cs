using System.ComponentModel.DataAnnotations.Schema;

namespace FoodCourtBlazor.Data;

public class ShoppingCart
{
    public Guid Id { get; set; }
    
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public ApplicationUser User { get; set; }

    public Guid ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
    
    public int Count { get; set; }
}