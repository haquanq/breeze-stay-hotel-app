using HotelManagement.Infrastructure.Common;
using HotelManagement.Domain.Dtos.RoomType;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories.RoomType;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Services.RoomType
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;

        public RoomTypeService(IRoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }

        public async Task<PageResponse<RoomTypeModel>> FindAsync(RoomTypeSearchDto searchParameter, PageRequest pageRequest)
        {
            return await _roomTypeRepository.FindAsync(searchParameter, pageRequest);
        }

        public async Task<RoomTypeModel> FindByIdAsync(string roomTypeId)
        {
            return await _roomTypeRepository.FindByIdAsync(roomTypeId);
        }

        public async Task CreateAsync(RoomTypeCreateDto roomTypeCreateDto)
        {
            await _roomTypeRepository.CreateAsync(roomTypeCreateDto);
        }

        public async Task UpdateAsync(RoomTypeUpdateDto roomTypeUpdateDto)
        {
            await _roomTypeRepository.UpdateAsync(roomTypeUpdateDto);
        }

        public async Task DeleteByIdAsync(string roomTypeId)
        {
            await _roomTypeRepository.DeleteByIdAsync(roomTypeId);
        }
    }
}
