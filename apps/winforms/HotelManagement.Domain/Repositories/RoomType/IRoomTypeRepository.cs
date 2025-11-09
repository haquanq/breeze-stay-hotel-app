using HotelManagement.Infrastructure.Common;
using HotelManagement.Domain.Dtos.RoomType;
using HotelManagement.Domain.Models;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Repositories.RoomType
{
    public interface IRoomTypeRepository
    {
        Task<PageResponse<RoomTypeModel>> FindAsync(RoomTypeSearchDto roomTypeSearchDto, PageRequest pageRequest);
        Task<RoomTypeModel> FindByIdAsync(string roomTypeId);
        Task CreateAsync(RoomTypeCreateDto roomTypeCreateDto);
        Task UpdateAsync(RoomTypeUpdateDto roomTypeUpdateDto);
        Task DeleteByIdAsync(string roomTypeId);
    }
}