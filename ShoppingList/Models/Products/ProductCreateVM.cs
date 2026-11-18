using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Models.Products
{
    public class ProductCreateVM
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "Името на продукта е задължително")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Името трябва да е между 3 и 50 символа")]
        public string ProductName { get; set; } = null!;
    }
}


