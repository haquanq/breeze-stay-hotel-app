using FluentValidation;
using HotelManagement.Domain.Dtos.Customer;

namespace HotelManagement.Domain.Validators.Customer
{
    public class CustomerCreateDtoValidator : AbstractValidator<CustomerCreateDto>
    {
        public CustomerCreateDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name can't be empty")
                .MaximumLength(100)
                .WithMessage("First name can't be more than 100 characters");
            RuleFor(x => x.LastName).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Email).EmailAddress().MaximumLength(100);
            RuleFor(x => x.Phone).Length(9, 10);
            RuleFor(x => x.CitizenIdNumber).NotEmpty();
            RuleFor(x => x.Address1).NotEmpty();
            RuleFor(x => x.Address2);
            RuleFor(x => x.Status).IsInEnum();
        }
    }
}
