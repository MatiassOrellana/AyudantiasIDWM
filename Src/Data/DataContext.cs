using Ayudantia1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ayudantia1.Context
{
    public class DataContext : DbContext
    {

        public DbSet<User> users { get; set;} = null;

        public DbSet<Role> roles { get; set;} = null;

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

    }
}