using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;

namespace eCommerce.Infrastructure.Repositories
{
    internal class UsersRepository : IUsersRepository
    {
        public Task<ApplicationUser?> AddUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
        {
            throw new NotImplementedException();
        }
    }
}
