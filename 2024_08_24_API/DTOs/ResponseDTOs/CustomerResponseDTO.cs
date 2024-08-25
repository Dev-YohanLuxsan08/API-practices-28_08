namespace _2024_08_24_API.DTOs.ResponseDTOs
{
    public class CustomerResponseDTO
    {
        public class CustomerResponse
        {
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public bool IsActive { get; set; }

        }
    }
}
