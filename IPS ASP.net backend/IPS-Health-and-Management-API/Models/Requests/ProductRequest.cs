namespace IPS_Health_and_Management_API.Models.Requests
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ImageData { get; set; }
        public int StockLevel { get; set; }
    }
}
