using HotelManagement.Infrastructure.Common;
using HotelManagement.Domain.Dtos.HotelService;
using HotelManagement.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Repositories.HotelService
{
    public interface IHotelServiceRepository
    {
        Task<PageResponse<HotelServiceModel>> FindAsync(HotelServiceSearchDto hotelservicesearchDto, PageRequest pageRequest);
        Task<HotelServiceModel> FindByIdAsync(string hotelServiceId);
        Task CreateAsync(HotelServiceCreateDto hotelServiceCreateDto);
        Task UpdateAsync(HotelServiceUpdateDto hotelServiceUpdateDto);
        Task DeleteByIdAsync(string hotelServiceId);

        Task InsertMany(List<HotelServiceCreateDto> data);
    }
}