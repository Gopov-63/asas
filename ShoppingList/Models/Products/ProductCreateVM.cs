using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Models.Products
{
    public class ProductCreateVM
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Име на продукта")]
        public string ProductName { get; set; } = null!;
    }
}
