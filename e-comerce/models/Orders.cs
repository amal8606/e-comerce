namespace e_comerce.models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string? PaymentStatus { get; set; }
        public string? ShippingAddress { get; set;}
        public string? ShippingCity { get; set; }
        public string? ShippingState { get; set; }
        public string? ShippingPostalCode { get; set; }
        public string? ShippingCountry { get; set; }
        public string? OrderStatus { get; set; }
        public decimal? TotalAmount { get; set; }



    }
}
