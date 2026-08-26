namespace StudentMarketplace.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property - one category can have many products
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
