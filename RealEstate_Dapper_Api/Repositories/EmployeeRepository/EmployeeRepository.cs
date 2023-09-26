using Dapper;
using RealEstate_Dapper_Api.Dtos.EmployeeDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "select * from Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }

        }

        public async void CreateEmployee(CreateEmployeeDto employeeDto)
        {
            string query = "insert into Employee (Name,Title,Mail,PhoneNumber,ImageUrl,Status) values (@name,@title,@mail,@phoneNumber,@imageUrl,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", employeeDto.Name);
            parameters.Add("@title", employeeDto.Title);
            parameters.Add("@mail", employeeDto.Mail);
            parameters.Add("@phoneNumber", employeeDto.PhoneNumber);
            parameters.Add("@imageUrl", employeeDto.ImageUrl);
            parameters.Add("@status", employeeDto.Status);
            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void UpdateEmployee(UpdateEmployeeDto employeeDto)
        {
            string query = "Update Employee Set Name=@name,Title=@title,Mail=@mail,PhoneNumber=@phoneNumber,ImageUrl=@imageUrl,Status=@status where Id = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@name", employeeDto.Name);
            parameters.Add("@title", employeeDto.Title);
            parameters.Add("@mail", employeeDto.Mail);
            parameters.Add("@phoneNumber", employeeDto.PhoneNumber);
            parameters.Add("@imageUrl", employeeDto.ImageUrl);
            parameters.Add("@status", employeeDto.Status);
            parameters.Add("@id", employeeDto.Id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query,parameters);
            }
        }

        public async void DeleteEmployee(int id)
        {
            string query = "Delete from Employee where Id = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
           
        }

        public async Task<GetByIDEmployeeDto> GetEmployee(int id)
        {
            string query = "Select * frm Employee where Id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            using (var connections = _context.CreateConnection())
            {
                var value = await connections.QueryFirstAsync<GetByIDEmployeeDto>(query, parameters);
                return value;
            }
        }

    }
}
