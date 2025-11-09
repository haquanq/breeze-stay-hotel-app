using HotelManagement.Infrastructure.Common;
using HotelManagement.Domain.Dtos.Room;
using HotelManagement.Domain.Models;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Repositories.Room
{
    public interface IRoomRepository
    {
        Task<PageResponse<RoomModel>> FindAsync(RoomSearchDto roomSearchDto, PageRequest pageRequest);
        Task<RoomModel> FindByIdAsync(string roomId);
        Task CreateAsync(RoomCreateDto roomCreateDto);
        Task UpdateAsync(RoomUpdateDto roomUpdateDto);
        Task DeleteByIdAsync(string roomId);
    }
}