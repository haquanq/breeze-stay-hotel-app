using HotelManagement.Domain.Dtos.Staff;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories.Staff;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Services.Staff
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _staffRepository;

        public EmployeeService(IEmployeeRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public async Task<PageResponse<StaffModel>> FindAsync(EmployeeSearchDto searchParams, PageRequest pageRequest)
        {
            return await _staffRepository.FindAsync(searchParams, pageRequest);
        }

        public async Task<StaffModel> FindByIdAsync(string staffId)
        {
            return await _staffRepository.FindByIdAsync(staffId);
        }

        public async Task CreateAsync(StaffCreateDto staff)
        {
            await _staffRepository.CreateAsync(staff);
        }

        public async Task UpdateAsync(StaffUpdateDto staff)
        {
            await _staffRepository.UpdateAsync(staff);
        }

        public async Task DeleteByIdAsync(string staffId)
        {
            await _staffRepository.DeleteByIdAsync(staffId);
        }
    }
}
