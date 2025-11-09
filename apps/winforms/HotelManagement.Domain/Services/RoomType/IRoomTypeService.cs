using HotelManagement.Infrastructure.Common;
using HotelManagement.Domain.Dtos.RoomType;
using HotelManagement.Domain.Models;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Services.RoomType
{
    public interface IRoomTypeService
    {
        Task<PageResponse<RoomTypeModel>> FindAsync(RoomTypeSearchDto roomTypeSearchDto, PageRequest pageRequest);
        Task<RoomTypeModel> FindByIdAsync(string roomTypeId);
        Task CreateAsync(RoomTypeCreateDto roomType);
        Task UpdateAsync(RoomTypeUpdateDto roomType);
        Task DeleteByIdAsync(string roomTypeId);
    }
}