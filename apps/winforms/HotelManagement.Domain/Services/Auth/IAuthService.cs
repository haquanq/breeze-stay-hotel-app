using HotelManagement.Domain.Dtos.Auth;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Services.Auth
{
    public interface IAuthService
    {
        Task<CurrentUserDto> Login(UserLoginDto data);
    }
}
