using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepository
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetPopularLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        void DeletePopularLocation(int id);
        Task<GetByIDPopularLocationDto> GetByIDPopularLocationAsync(int id);
    }
}
