using _2024_08_24_API.Database;
using _2024_08_24_API.Models;
using Azure.Core;
using Microsoft.EntityFrameworkCore;

namespace _2024_08_24_API.Repository.CustomerRepository
{
    public class CustomerRepository:IcustomerRepository
    {
        private readonly AppDBContext _dbContext;

        public CustomerRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Customer_Model> CreateCustomer(Customer_Model customer)
        {
            await _dbContext.AddAsync(customer);
            await _dbContext.SaveChangesAsync();
            return customer;
        }

        //public async Task<Customer_Model> UpdateCustomer(Customer_Model customer)
        //{
        //    var customer = _dbContext.Cus

        //}



    }
}
