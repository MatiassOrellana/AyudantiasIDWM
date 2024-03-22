using Ayudantia1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ayudantia1.Context
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<User> users { get; set; }

        public DbSet<Role> roles { get; set; }

        

    }
}