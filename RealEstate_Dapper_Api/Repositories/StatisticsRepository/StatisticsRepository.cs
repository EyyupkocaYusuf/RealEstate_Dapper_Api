using Dapper;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.StatisticsRepository
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly Context _context;

        public StatisticsRepository(Context context)
        {
            _context = context;
        }

        public int ActiveCategoryCount()
        {
            string query = "Select Count(*) From Category Where CategoryStatus = 1";
            using (var connections = _context.CreateConnection())
            {
                var values =  connections.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ActiveEmployeeCount()
        {
            string query = "Select Count(*) From Employee Where Status = 1";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ApartmentCount()
        {
            string query = "Select Count(*) From Product Where Title like '%Daire%'";  
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public decimal AverageProductPriceByRent()
        {
            string query = "Select Avg(Price) From Product Where Type = 'Kiralık'";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public decimal AverageProductPriceBySale()
        {
            string query = "Select Avg(Price) From Product Where Type = 'Satılık'";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public decimal AverageRoomCount()
        {
            throw new NotImplementedException();
        }

        public int CategoryCount()
        {
            string query = "Select Count(*) From Category ";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public string CategoryNameByMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public string CityNameByMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public int DifferentCityCount()
        {
            throw new NotImplementedException();
        }

        public string EmployeeNameByMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public decimal LastProductPrice()
        {
            throw new NotImplementedException();
        }

        public string NewestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public string OldestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public int PassiveCategoryCount()
        {
            string query = "Select Count(*) From Category Where CategoryStatus = 0";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ProductCount()
        {
            string query = "Select Count(*) From Product";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
        }
    }
}
