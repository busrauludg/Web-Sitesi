using Services.Constract;
using Repositories.Contracts;

namespace Services
{
    public class UserService : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IUserRepository UserRepository => _userRepository;

        public bool AuthenticateUser(string email, string password)
    {
        // UserRepository ile kullanıcıyı email ve şifreye göre kontrol et
        return _userRepository.GetUserByEmailAndPassword(email, password) != null;
    }


    }
}