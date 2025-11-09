using HotelManagement.Domain.Dtos.Customer;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories.Customer;
using System.Threading.Tasks;
using FluentValidation;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IValidator<CustomerCreateDto> _customerCreateDtoValidator;
        private readonly IValidator<CustomerUpdateDto> _customerUpdateDtoValidator;

        public CustomerService(ICustomerRepository customerRepository,
            IValidator<CustomerCreateDto> customerCreateDtoValidator,
            IValidator<CustomerUpdateDto> customerUpdateDtoValidator
            )
        {
            _customerRepository = customerRepository;
            _customerCreateDtoValidator = customerCreateDtoValidator;
            _customerUpdateDtoValidator = customerUpdateDtoValidator;
        }

        public async Task<PageResponse<CustomerModel>> FindAsync(CustomerSearchDto customerSearchDto, PageRequest pageRequest)
        {
            return await _customerRepository.FindAsync(customerSearchDto, pageRequest);
        }

        public async Task<CustomerModel> FindByIdAsync(string customerId)
        {
            return await _customerRepository.FindByIdAsync(customerId);
        }

        public async Task CreateAsync(CustomerCreateDto customer)
        {
            _customerCreateDtoValidator.ValidateAndThrow(customer);
            await _customerRepository.CreateAsync(customer);
        }

        public async Task UpdateAsync(CustomerUpdateDto customer)
        {
            _customerUpdateDtoValidator.ValidateAndThrow(customer);
            await _customerRepository.UpdateAsync(customer);
        }

        public async Task DeleteByIdAsync(string customerId)
        {
            await _customerRepository.DeleteByIdAsync(customerId);
        }
    }
}
