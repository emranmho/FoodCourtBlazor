using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodCourtBlazor.Data;

public class OrderCart
{
    public Guid Id { get; set; }

    [Required]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public ApplicationUser User { get; set; }

    [Required]
    [Display(Name = "Order Total")]
    public double OrderTotal { get; set; }
    
    [Required]
    [Display(Name = "Order Date")]
    public DateTime OrderDate { get; set; }
    
    public DateTime LastUpdateDate { get; set; }
    [Required]
    public string Status { get; set; }
    
    [Required]
    [Display(Name = "Name")]
    public string Name { get; set; }
    
    [Required]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }
    
    [Required]
    public string Address { get; set; }
    
    public ICollection<OrderCartDetails> OrderCartDetails { get; set; } = new List<OrderCartDetails>();
}