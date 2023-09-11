using RealEstate_Dapper_Api.Dtos.BottomGridDtos;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGridAsync(CreateBottomGridDto bottomGridDto);
        void DeleteBottomGridAsync(int id);
        void UpdateBottomGridAsync(UpdateBottomGridDto bottomGridDto);
        Task<GetByIDBottomGridDto> GetBottomGridAsync(int id);
    }
}
