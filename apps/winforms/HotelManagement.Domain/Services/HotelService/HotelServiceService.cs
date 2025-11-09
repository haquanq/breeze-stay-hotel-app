using HotelManagement.Domain.Dtos.HotelService;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories.HotelService;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Services.HotelService
{
    public class HotelServiceService : IHotelServiceService
    {
        private readonly IHotelServiceRepository _hotelServiceRepository;

        public HotelServiceService(IHotelServiceRepository hotelServiceRepository)
        {
            _hotelServiceRepository = hotelServiceRepository;
        }

        public async Task<PageResponse<HotelServiceModel>> FindAsync(HotelServiceSearchDto searchParameter, PageRequest pageRequest)
        {
            return await _hotelServiceRepository.FindAsync(searchParameter, pageRequest);
        }

        public async Task<HotelServiceModel> FindByIdAsync(string hotelServiceId)
        {
            return await _hotelServiceRepository.FindByIdAsync(hotelServiceId);
        }

        public async Task CreateAsync(HotelServiceCreateDto hotelService)
        {
            await _hotelServiceRepository.CreateAsync(hotelService);
        }

        public async Task UpdateAsync(HotelServiceUpdateDto hotelService)
        {
            await _hotelServiceRepository.UpdateAsync(hotelService);
        }

        public async Task DeleteByIdAsync(string hotelServiceId)
        {
            await _hotelServiceRepository.DeleteByIdAsync(hotelServiceId);
        }
    }
}
