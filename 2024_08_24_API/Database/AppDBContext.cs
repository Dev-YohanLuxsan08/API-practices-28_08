
using _2024_08_24_API.Models;
using Microsoft.EntityFrameworkCore;

namespace _2024_08_24_API.Database
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Customer_Model> Products { get; set; }
        public DbSet<Employee_Model> Employees { get; set; }
        public DbSet<Order_Model> Orders { get; set; }
        public DbSet<OrderDetails_Model> OrderDetails { get; set; }
    }  
}
