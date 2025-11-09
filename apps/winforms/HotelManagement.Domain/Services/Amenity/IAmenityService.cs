using HotelManagement.Domain.Dtos.Amenity;
using HotelManagement.Domain.Models;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Services.Amenity
{
    public interface IAmenityService
    {
        Task<PageResponse<AmenityModel>> FindAsync(AmenitySearchDto amenitySearchDto, PageRequest pageRequest);
        Task<AmenityModel> FindByIdAsync(string amenityId);
        Task CreateAsync(AmenityCreateDto amenityCreateDto);
        Task UpdateAsync(AmenityUpdateDto amenityUpdateDto);
        Task DeleteByIdAsync(string amenityId);
    }
}