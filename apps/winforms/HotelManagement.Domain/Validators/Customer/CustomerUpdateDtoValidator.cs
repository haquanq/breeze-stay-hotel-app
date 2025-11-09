using FluentValidation;
using HotelManagement.Domain.Dtos.Customer;

namespace HotelManagement.Domain.Validators.Customer
{
    public class CustomerUpdateDtoValidator : AbstractValidator<CustomerUpdateDto>
    {
        public CustomerUpdateDtoValidator()
        {
            RuleFor(x => x.CustomerId).NotNull();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().MaximumLength(100);
            RuleFor(x => x.Phone).Length(9, 10);
            RuleFor(x => x.CitizenIdNumber).NotEmpty();
            RuleFor(x => x.Address1).NotEmpty();
            RuleFor(x => x.Address2);
            RuleFor(x => x.Status).IsInEnum();
        }
    }
}
