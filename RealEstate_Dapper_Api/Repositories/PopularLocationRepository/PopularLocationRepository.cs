using Dapper;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepository
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultPopularLocationDto>> GetPopularLocationAsync()
        {
            var query = "Select * From PopularLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }

        public async void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            var query = "insert into PopularLocation (ImageUrl,CityName) values (@imageUrl,@cityName)";
            var parameters = new DynamicParameters();
            parameters.Add("@imageUrl", createPopularLocationDto.ImageUrl);
            parameters.Add("@cityName", createPopularLocationDto.CityName);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            var query = "Update PopularLocation Set ImageUrl=@imageUrl,CityName=@cityName where PopularLocationID=@popularLocationID";
            var parameters = new DynamicParameters();
            parameters.Add("@imageUrl",updatePopularLocationDto.ImageUrl);
            parameters.Add("@cityName",updatePopularLocationDto.CityName);
            parameters.Add("@popularLocationID",updatePopularLocationDto.PopularLocationID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query,parameters);
            }
        }

        public async void DeletePopularLocation(int id)
        {
            var query = "Delete From PopularLocation Where PopularLocationID=@popularLocationID";
            var parameters = new DynamicParameters();
            parameters.Add("@popularLocationID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetByIDPopularLocationDto> GetByIDPopularLocationAsync(int id)
        {
            var query = "Select * From PopularLocation Where PopularLocationID=@popularLocationID";
            var parameters = new DynamicParameters();
            parameters.Add("@popularLocationID", id);

            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIDPopularLocationDto>(query,parameters);
                return value;
            }
        }

    }
}
