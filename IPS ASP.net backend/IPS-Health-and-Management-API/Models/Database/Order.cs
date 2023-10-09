namespace IPS_Health_and_Management_API.Models.Database
{
    public class Order : Entity
    {
        public virtual Cart Cart { get; set; }
        public virtual int CartId { get; set; }
        public DateTime DateOccured { get; set; }
        
    }
}
