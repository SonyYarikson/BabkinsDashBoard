using Models.Repositories.RepositoryInterfaces;
using Models.Services.Interfaces;

namespace Models.Services.Implementation
{
    public class AuthoriseService : IAuthoriseService
    {
        private IUserRepository _userRepository;

        public AuthoriseService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> TryAuthorizeUser(string login, string password)
        {
            // string hashPassword = MD5Hash.CalculateMD5Hash(password);
            var result = await _userRepository.GetUserByLoginAndPassword(login, password);
            return result;
        }

        public async Task<User> RegistrateUser(User user)
        {
            await _userRepository.AddItem(user);

            return user;
        }
    }
}
