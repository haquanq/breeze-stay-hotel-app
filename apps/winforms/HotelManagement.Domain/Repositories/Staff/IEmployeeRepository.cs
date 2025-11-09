using HotelManagement.Domain.Dtos.Staff;
using HotelManagement.Domain.Models;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Repositories.Staff
{
    public interface IEmployeeRepository
    {
        Task<PageResponse<StaffModel>> FindAsync(EmployeeSearchDto staffSearchDto, PageRequest page);
        Task<StaffModel> FindByIdAsync(string staffId);
        Task CreateAsync(StaffCreateDto staffCreateDto);
        Task UpdateAsync(StaffUpdateDto staffUpdateDto);
        Task DeleteByIdAsync(string staffId);
    }
}