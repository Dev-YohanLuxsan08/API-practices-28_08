namespace _2024_08_24_API.DTOs.ResponseDTOs
{
    public class OrderResponseDTO
    {
        public class OrderResponse
        {
            public Guid Id { get; set; }
            public Guid CustomerId { get; set; }
            public DateTime OrderDate { get; set; }
            public decimal TotalAmount { get; set; }

        }
    }
}
