namespace StudentMarketplace.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation property - one user can own many businesses
        public ICollection<Business> Businesses { get; set; } = new List<Business>();
    }
}
