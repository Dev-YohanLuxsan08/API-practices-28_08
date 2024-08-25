namespace _2024_08_24_API.Models
{
    public class Customer_Model
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public bool IsActive {  get; set; }
    }
}
