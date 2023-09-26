using Dapper;
using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepository
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "Select * From BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }
        public async void CreateBottomGridAsync(CreateBottomGridDto bottomGridDto)
        {
            string query = "insert into BottomGrid (Icon,Title,Description) values (@icon,@title,@description)";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", bottomGridDto.Icon);
            parameters.Add("@title", bottomGridDto.Title);
            parameters.Add("@description", bottomGridDto.Description);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void UpdateBottomGridAsync(UpdateBottomGridDto bottomGridDto)
        {
            string query = "Update BottomGrid Set Icon=@icon,Title=@title,Description=@description where BottomGirdID=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", bottomGridDto.Icon);
            parameters.Add("@title", bottomGridDto.Title);
            parameters.Add("@description", bottomGridDto.Description);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async void DeleteBottomGridAsync(int id)
        {
            string query = "Delete From BottomGrid where BottomGridID = @bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetByIDBottomGridDto> GetBottomGridAsync(int id)
        {
            string query = "Select * from BottomGrid where BottomGridID = @bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);

            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIDBottomGridDto>(query, parameters);
                return value;
            }
        }

    }
}
