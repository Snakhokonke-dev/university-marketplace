namespace StudentMarketplace.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAvailable { get; set; }
        public int BusinessId { get; set; } // Foreign key to Business
        public int CategoryId { get; set; } // Foreign key to Category
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public Business Business { get; set; } // Many to One with Business
        public Category Category { get; set; } // Many to One with Category
    }
}