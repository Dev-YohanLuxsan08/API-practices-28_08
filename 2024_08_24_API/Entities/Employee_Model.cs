namespace _2024_08_24_API.Models
{
    public class Employee_Model
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredDAte { get; set; }
        public string Department {  get; set; }
        public string JobTitle {  get; set; }
    }
}
