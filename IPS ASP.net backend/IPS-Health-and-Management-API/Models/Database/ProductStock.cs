namespace IPS_Health_and_Management_API.Models.Database
{
    public class ProductStock : Entity
    {
        public virtual Product Product { get; set; }
        public virtual int ProductId { get; set; }
        public DateTime DateTaken { get; set; }
        public int StockLevel { get; set; }
        public decimal Price { get; set; }
    }
}
