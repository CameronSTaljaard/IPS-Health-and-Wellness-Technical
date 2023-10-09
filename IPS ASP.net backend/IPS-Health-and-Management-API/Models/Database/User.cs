namespace IPS_Health_and_Management_API.Models.Database
{
    public class User : Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
