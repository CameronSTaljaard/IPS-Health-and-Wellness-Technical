namespace IPS_Health_and_Management_API.Models.Responses
{
    public class CartProductResponse
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public string productImage { get; set; }
        public decimal productPrice { get; set; }
        public string productBrief { get; set; }
        public int productQuantity { get; set; }
    }
}
