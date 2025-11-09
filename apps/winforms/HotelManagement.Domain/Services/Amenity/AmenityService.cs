using HotelManagement.Domain.Dtos.Amenity;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories.Amenity;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Services.Amenity
{
    public class AmenityService : IAmenityService
    {
        private readonly IAmenityRepository _amenityRepository;

        public AmenityService(IAmenityRepository amenityRepository)
        {
            _amenityRepository = amenityRepository;
        }

        public async Task<PageResponse<AmenityModel>> FindAsync(AmenitySearchDto amenitySearchDto, PageRequest pageRequest)
        {
            return await _amenityRepository.FindAsync(amenitySearchDto, pageRequest);
        }

        public async Task<AmenityModel> FindByIdAsync(string amenityId)
        {
            return await _amenityRepository.FindByIdAsync(amenityId);
        }

        public async Task CreateAsync(AmenityCreateDto amenityCreateDto)
        {
            await _amenityRepository.CreateAsync(amenityCreateDto);
        }

        public async Task UpdateAsync(AmenityUpdateDto amenityUpdateDto)
        {
            await _amenityRepository.UpdateAsync(amenityUpdateDto);
        }

        public async Task DeleteByIdAsync(string amenityId)
        {
            await _amenityRepository.DeleteByIdAsync(amenityId);
        }
    }
}
