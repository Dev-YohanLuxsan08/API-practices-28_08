namespace _2024_08_24_API.DTOs.ResponseDTOs
{
    public class ProductResponseDTO
    {
        public class ProductResponse
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

        }
    }
}
