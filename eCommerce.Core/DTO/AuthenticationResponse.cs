namespace eCommerce.Core.DTO;

public record AuthenticationResponse(
    Guid UserID,
    string? Email,
    string? PersonName,
    string? Gender,
    string? Token,
    bool Success
    )
{
    //parameterless constructor for the automapper to work
    public AuthenticationResponse() : this(Guid.Empty, null, null, null, null, false)
    {

    }
}
