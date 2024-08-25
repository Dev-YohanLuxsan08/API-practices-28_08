using _2024_08_24_API.Models;

namespace _2024_08_24_API.Repository.CustomerRepository
{
    public interface IcustomerRepository
    {
        Task<Customer_Model> CreateCustomer(Customer_Model customer);
        Task<Customer_Model> UpdateCustomer(Customer_Model customer);
        Task<Customer_Model> DeleteCustomer(Customer_Model ID);
        Task<Customer_Model> GetByCustomerID(Customer_Model ID);
    }
}
