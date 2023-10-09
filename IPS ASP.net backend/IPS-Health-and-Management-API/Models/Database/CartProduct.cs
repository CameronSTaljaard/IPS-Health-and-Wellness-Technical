namespace IPS_Health_and_Management_API.Models.Database
{
    public class CartProduct : Entity
    {
        public Cart Cart { get; set; }
        public Product Product { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
    }
}
