namespace IPS_Health_and_Management_API.Models.Database
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; }
    }
}
