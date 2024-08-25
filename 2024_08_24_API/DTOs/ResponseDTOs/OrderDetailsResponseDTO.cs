namespace _2024_08_24_API.DTOs.ResponseDTOs
{
    public class OrderDetailsResponseDTO
    {
        public class OrderDetailResponse
        {
            public Guid Id { get; set; }
            public Guid OrderId { get; set; }
            public Guid ProductId { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
        }
    }
}
