using HotelManagement.Domain.Dtos.Amenity;
using HotelManagement.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Repositories.Amenity
{
    public interface IAmenityRepository
    {
        Task<PageResponse<AmenityModel>> FindAsync(AmenitySearchDto amenitySearchDto, PageRequest pageRequest);
        Task<AmenityModel> FindByIdAsync(string amenityId);
        Task CreateAsync(AmenityCreateDto amenity);
        Task UpdateAsync(AmenityUpdateDto amenity);
        Task DeleteByIdAsync(string amenityId);

        /// need clean up
        Task InsertMany(List<AmenityCreateDto> amenity);
    }
}
