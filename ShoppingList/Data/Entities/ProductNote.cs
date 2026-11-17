using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Data.Entities
{
    public class ProductNote
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Content { get; set; } = null!;

        // Външен ключ
        public int ProductId { get; set; }

        // Навигационно свойство
        public Product Product { get; set; } = null!;
    }
}
