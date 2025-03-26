using Repositories.Contracts;

namespace Services.Constract
{
    public interface IUserServices
    {
        IUserRepository UserRepository { get; }

         bool AuthenticateUser(string email, string password);
    }
}
