namespace StudentMarketplace.Models
{
    public class Business
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string University { get; set; }
        public string WhatsAppNumber { get; set; }
        public string LogoUrl { get; set; }
        public bool IsActive { get; set; }
        public int OwnerId { get; set; } // Foreign key to User
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public User Owner { get; set; } // Many to One with User
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
