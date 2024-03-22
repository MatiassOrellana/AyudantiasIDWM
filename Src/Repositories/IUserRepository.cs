using Ayudantia1.Models;

namespace Ayudantia1.Src.Repositories
{
    public interface IUserRepository
    {
        
         public Task<List<User>> GetUsers();
    }
}