using Ayudantia1.src.Context;
using Ayudantia1.src.Models;
using Microsoft.EntityFrameworkCore;

namespace Ayudantia1.src.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsers()
        {
            var users = await _context.users.ToListAsync();
            return users;
        }

    }
}