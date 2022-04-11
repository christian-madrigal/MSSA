using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Assignment_13._3.Models
{
    public class CustomerContext : IdentityDbContext<Customer>
    {
        public CustomerContext(DbContextOptions<CustomerContext> options): base(options)
        {

        }
    }
}
