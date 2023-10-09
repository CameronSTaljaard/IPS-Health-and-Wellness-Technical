namespace IPS_Health_and_Management_API.Models.Database
{
    public class Cart : Entity
    {
        public virtual User User { get; set; }
        public virtual int UserId { get; set; }
        public virtual Order? Order { get; set; }
        public virtual int? OrderId { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
