using Entities.Models;


namespace Repositories.Contracts
{
    public class UserRepository :IUserRepository
    {
        private readonly RepositoryContext _context;

        public UserRepository(RepositoryContext context)
        {
            _context = context; 
        }

        public User? GetUserByEmailAndPassword(string email,string password)
        {
            return _context.Users.FirstOrDefault(u=>u.Email==email&& u.Password==password);
        }

        // public UserProfile GetProfileByUsername(int UserId)
        // {
        //     return _context.Users
        //     .Where(u=>u.UserId==userId)
        //     .Select(u=>new UserProfile
        //     {
        //         UserName=u.UserName,
        //         Email=u.Email
        //     }).FirstOrDefault();
        // }
    }
}