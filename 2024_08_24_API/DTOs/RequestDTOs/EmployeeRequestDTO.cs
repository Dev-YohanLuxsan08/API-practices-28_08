namespace _2024_08_24_API.DTOs.RequestDTOs
{
    public class EmployeeRequestDTO
    {
        public class EmployeeRequest
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime HireDate { get; set; }
            public string Department { get; set; }
            public string JobTitle { get; set; }
        }
    }
}
