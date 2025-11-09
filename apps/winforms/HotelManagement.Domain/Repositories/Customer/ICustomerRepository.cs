using HotelManagement.Domain.Dtos.Customer;
using HotelManagement.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Repositories.Customer
{
    public interface ICustomerRepository
    {
        Task<PageResponse<CustomerModel>> FindAsync(CustomerSearchDto customerSearchDto, PageRequest pageRequest);
        Task<CustomerModel> FindByIdAsync(string customerId);
        Task CreateAsync(CustomerCreateDto customer);
        Task UpdateAsync(CustomerUpdateDto customer);
        Task DeleteByIdAsync(string customerId);

        /// clean up later
        Task InsertMany(List<CustomerCreateDto> customers);
    }
}