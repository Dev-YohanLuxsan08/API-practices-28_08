namespace _2024_08_24_API.DTOs.RequestDTOs
{
    public class OrderRequestDTO
    {
        public class OrderRequest
        {
            public Guid CustomerId { get; set; }
            public DateTime OrderDate { get; set; }
            public decimal TotalAmount { get; set; }
        }
    }
}
