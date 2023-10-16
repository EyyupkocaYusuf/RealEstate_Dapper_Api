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
                var values = connections.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public decimal AverageProductPriceBySale()
        {
            string query = "Select Avg(Price) From Product Where Type = 'Satılık'";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public decimal AverageRoomCount()
        {
            string query = "Select Avg(RoomCount) From ProductDetails ";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
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
            string query = "Select Top(1) CategoryName,Count(*) From Product inner join Category " +
                            "On Product.ProductCategory = Category.CategoryID" +
                            "Group By CategoryName " +
                            "order by Count(*) Desc ";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public string CityNameByMaxProductCount()
        {
            string query = "Select Top(1) City,Count(*) From Product group by City order by Count(*) Desc ";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public int DifferentCityCount()
        {
            string query = "Select Count(DISTINCT(City)) From Product";
            using (var connections = _context.CreateConnection())
            {
                var values = connections.QueryFirstOrDefault<int>(query);
                return values;
            }
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
