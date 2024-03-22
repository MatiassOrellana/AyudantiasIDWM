using Ayudantia1.src.Models;
using Microsoft.EntityFrameworkCore;

namespace Ayudantia1.src.Context
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<User> users { get; set; } = null;

        public DbSet<Role> roles { get; set; } = null;

        

    }
}