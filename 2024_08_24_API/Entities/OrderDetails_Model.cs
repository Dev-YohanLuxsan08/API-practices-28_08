using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_08_24_API.Models
{
    public class OrderDetails_Model
    {
        public Guid Id { get; set; }

        [ForeignKey("orderID")]
        public Guid OrderID { get; set; }

        [ForeignKey("ProductID")]
        public Guid ProductID { get; set; }
        public int Quantity {  get; set; }
        public decimal UnitPrize { get; set; }
    }
}
