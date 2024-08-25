namespace _2024_08_24_API.Models
{
    public class Order_Model
    {
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public DateTime OrderDAte { get; set; }
        public decimal TotalAmount {  get; set; }
    }
}
