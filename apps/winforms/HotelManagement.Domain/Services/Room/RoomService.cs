using HotelManagement.Domain.Dtos.Room;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories.Room;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository amenityRepository)
        {
            _roomRepository = amenityRepository;
        }

        public async Task<PageResponse<RoomModel>> FindAsync(RoomSearchDto searchParameter, PageRequest pageRequest)
        {
            return await _roomRepository.FindAsync(searchParameter, pageRequest);
        }

        public async Task<RoomModel> FindByIdAsync(string roomId)
        {
            return await _roomRepository.FindByIdAsync(roomId);
        }

        public async Task CreateAsync(RoomCreateDto amenity)
        {
            await _roomRepository.CreateAsync(amenity);
        }

        public async Task UpdateAsync(RoomUpdateDto amenity)
        {
            await _roomRepository.UpdateAsync(amenity);
        }

        public async Task DeleteByIdAsync(string amenityId)
        {
            await _roomRepository.DeleteByIdAsync(amenityId);
        }
    }
}
