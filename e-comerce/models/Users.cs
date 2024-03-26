namespace e_comerce.models
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerFlName { get; set; } = string.Empty;
        public string Email { get; set; }
        public string? passwordHash { get; set; }
        public string? Address { get; set; }
        public string? City { get; set;}
        public string? Region { get; set; }
        public string? PostalCode { get; set;}
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public DateTime? RegisteredAt { get; set;}



    }
}
