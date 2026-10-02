using eCommerce.Core.DTO;
using FluentValidation;
namespace eCommerce.Core.Validators;

public class RegisterRequestValidator:AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        //Email
        RuleFor(temp => temp.Email).NotEmpty().WithMessage("Email is required")
        .EmailAddress().WithMessage("Invalid Email Address format");

        //Password
        RuleFor(temp => temp.Password).NotEmpty().WithMessage("Password is required");

        //PersonName
        RuleFor(temp => temp.Password).NotEmpty().WithMessage("Person Name is required")
            .Length(1, 50).WithMessage("Person name cannot exceed 50 characters");

        //Gender
        RuleFor(temp => temp.Gender).IsInEnum().WithMessage("Invalid gender value"); 
    }
}
