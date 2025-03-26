using Entities.Models;

namespace Repositories.Contracts
{
    public interface IUserRepository
    {
        User? GetUserByEmailAndPassword(string email,string password);
    }
}