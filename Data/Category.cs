using System.ComponentModel.DataAnnotations;

namespace FoodCourtBlazor.Data;

public class Category
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Please enter name..")]
    public required string Name { get; set; }
}