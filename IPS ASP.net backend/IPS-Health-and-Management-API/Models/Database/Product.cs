namespace IPS_Health_and_Management_API.Models.Database
{
    public class Product : Entity
    {
        public virtual Category Category { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual ICollection<ProductStock> ProductStocks { get; }
        public virtual ICollection<CartProduct> CartProducts { get; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ImageData { get; set; }
        
    }
}
