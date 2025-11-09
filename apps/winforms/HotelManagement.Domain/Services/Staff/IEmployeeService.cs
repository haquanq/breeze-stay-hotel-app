using HotelManagement.Infrastructure.Common;
using HotelManagement.Domain.Dtos.Staff;
using HotelManagement.Domain.Models;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Services.Staff
{
    public interface IEmployeeService
    {
        Task<PageResponse<StaffModel>> FindAsync(EmployeeSearchDto staffSearchDto, PageRequest pageRequest);
        Task<StaffModel> FindByIdAsync(string staffId);
        Task CreateAsync(StaffCreateDto staffCreateDto);
        Task UpdateAsync(StaffUpdateDto staffUpdateDto);
        Task DeleteByIdAsync(string staffId);
    }
}