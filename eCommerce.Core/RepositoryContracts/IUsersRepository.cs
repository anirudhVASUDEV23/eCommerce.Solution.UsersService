using eCommerce.Core.Entities;

namespace eCommerce.Core.RepositoryContracts;

public interface IUsersRepository
{
    Task<ApplicationUser?> AddUser(ApplicationUser user);
    Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password);

    //For Microservice Communication through http/rest protocol this endpoint is used by the other services
    Task<ApplicationUser?> GetUserByUserID(Guid? userID);
}
