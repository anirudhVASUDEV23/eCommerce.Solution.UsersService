using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;
using Dapper;

namespace eCommerce.Infrastructure.Repositories
{
    internal class UsersRepository : IUsersRepository
    {
        private readonly DapperDbContext _dapperDbContext;

        public UsersRepository(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
        }

        public async Task<ApplicationUser?> AddUser(ApplicationUser user)
        {
            //Generate a new UserID
            user.UserID = Guid.NewGuid();
            string query= "INSERT INTO public.\"Users\" (\"UserID\", \"Email\", \"Password\", \"PersonName\", \"Gender\") VALUES (@UserID, @Email, @Password, @PersonName, @Gender)";
            int rowCountAffected = await _dapperDbContext.DbConnection.ExecuteAsync(query, user);
            if(rowCountAffected>0)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
        {
            string query = "SELECT * FROM public.\"Users\" WHERE \"Email\" = @Email AND \"Password\" = @Password";
            var parameters = new { Email = email, Password = password };
            ApplicationUser? user=await _dapperDbContext.DbConnection.QueryFirstOrDefaultAsync<ApplicationUser>(query, parameters);
            return user;
        }
    }
}
