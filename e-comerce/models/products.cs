namespace e_comerce.models
{
    public class products
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string? productDescription { get; set; }
        public string? productCategory { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }

    }
}
