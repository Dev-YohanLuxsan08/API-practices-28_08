namespace _2024_08_24_API.DTOs.RequestDTOs
{
    public class OrderDetailsRequestDTO
    {
        public class OrderDetailRequest
        {
            public Guid OrderId { get; set; }
            public Guid ProductId { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }

        }
    }
}
