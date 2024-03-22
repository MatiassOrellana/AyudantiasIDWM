using Ayudantia1.src.Models;

namespace Ayudantia1.src.Repositories
{
    public interface IUserRepository
    {
        
         public Task<List<User>> GetUsers();
    }
}