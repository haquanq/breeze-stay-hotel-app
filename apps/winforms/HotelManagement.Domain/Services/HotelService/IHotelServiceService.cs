using HotelManagement.Infrastructure.Common;
using HotelManagement.Domain.Dtos.HotelService;
using HotelManagement.Domain.Models;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Services.HotelService
{
    public interface IHotelServiceService
    {
        Task<PageResponse<HotelServiceModel>> FindAsync(HotelServiceSearchDto hotelServiceSearchDto, PageRequest pageRequest);
        Task<HotelServiceModel> FindByIdAsync(string hotelServiceId);
        Task CreateAsync(HotelServiceCreateDto hotelServiceCreateDto);
        Task UpdateAsync(HotelServiceUpdateDto hotelServiceUpdateDto);
        Task DeleteByIdAsync(string hotelServiceId);
    }
}