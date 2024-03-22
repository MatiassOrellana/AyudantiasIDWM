using Ayudantia1.Context;
using Ayudantia1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ayudantia1.Src.Repositories
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