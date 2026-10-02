using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;

namespace eCommerce.Core.Services
{
    internal class UsersService : IUsersService
    {
        public Task<AuthenticationResponse?> Login(LoginRequest loginRequest)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
        {
            throw new NotImplementedException();
        }
    }
}
