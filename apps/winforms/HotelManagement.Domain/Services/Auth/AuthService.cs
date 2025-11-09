using HotelManagement.Domain.Dtos.Auth;
using HotelManagement.Domain.Repositories.Staff;
using HotelManagement.Domain.Exceptions.Auth;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;
using HotelManagement.Domain.Dtos.Staff;
using System.Linq;

namespace HotelManagement.Domain.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IEmployeeRepository _employeeRepository;

        private EmployeeSearchDto _employeeSearchDto;

        public AuthService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<CurrentUserDto> Login(UserLoginDto data)
        {
            var page = new PageRequest()
            {
                OffsetElements = 1,
                PageNumber = 1
            };

            var result = await _employeeRepository.FindAsync(_employeeSearchDto, page);

            if (result.Content.Count() == 0) { throw new UnauthenticatedException("Email or user does not exist"); }

            var userInfo = result.Content.First();

            if (userInfo.Email == data.Email && userInfo.AccountPassword == data.Password)
            {
                return new CurrentUserDto
                {
                    Email = userInfo.Email,
                    FullName = userInfo.FirstName + " " + userInfo.LastName,
                    Phone = userInfo.Phone,
                    Role = userInfo.Role,
                    StaffId = userInfo.StaffId
                };
            }
            throw new UnauthenticatedException("Wrong email or password");
        }
    }
}
