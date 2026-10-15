using eCommerce.Core.DTO;

namespace eCommerce.Core.ServiceContracts;

public interface IUsersService
{
    Task<AuthenticationResponse?> Login(LoginRequest loginRequest);
    Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);

    //Servoce method for microservice communication
    Task<UserDTO?> GetUserByUserID(Guid userID);
}
