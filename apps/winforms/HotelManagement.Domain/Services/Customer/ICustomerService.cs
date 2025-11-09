using HotelManagement.Infrastructure.Common;
using HotelManagement.Domain.Dtos.Customer;
using HotelManagement.Domain.Models;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Services.Customer
{
    public interface ICustomerService
    {
        Task<PageResponse<CustomerModel>> FindAsync(CustomerSearchDto searchParam, PageRequest pageRequest);
        Task<CustomerModel> FindByIdAsync(string customerId);
        Task CreateAsync(CustomerCreateDto customerCreateDto);
        Task UpdateAsync(CustomerUpdateDto customerUpdateDto);
        Task DeleteByIdAsync(string customerId);
    }
}