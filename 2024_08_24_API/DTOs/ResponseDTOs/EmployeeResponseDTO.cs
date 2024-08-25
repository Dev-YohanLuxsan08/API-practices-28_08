namespace _2024_08_24_API.DTOs.ResponseDTOs
{
    public class EmployeeResponseDTO
    {
        public class EmployeeResponse
        {
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime HireDate { get; set; }
            public string Department { get; set; }
            public string JobTitle { get; set; }

        }
    }
}
