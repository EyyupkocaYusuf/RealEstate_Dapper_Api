using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region İstatistik1
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7243/api/Statistics/ActiveCategoryCount");
            ViewBag.ActiveCategoryCount = await responseMessage.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:7243/api/Statistics/PassiveCategoryCount");
            ViewBag.PassiveCategoryCount = await responseMessage2.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:7243/api/Statistics/ActiveEmployeeCount");
            ViewBag.ActiveEmployeeCount = await responseMessage3.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:7243/api/Statistics/ProductCount");
            ViewBag.ProductCount = await responseMessage4.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:7243/api/Statistics/ApartmentCount");
            ViewBag.ApartmentCount = await responseMessage5.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:7243/api/Statistics/AverageProductPriceByRent");
            ViewBag.AverageProductPriceByRent = await responseMessage6.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:7243/api/Statistics/AverageProductPriceBySale");
            ViewBag.AverageProductPriceBySale = await responseMessage7.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik8
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:7243/api/Statistics/CategoryCount");
            ViewBag.CategoryCount = await responseMessage8.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik9
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:7243/api/Statistics/AverageRoomCount");
            ViewBag.AverageRoomCount = await responseMessage9.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik10
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:7243/api/Statistics/CategoryNameByMaxProductCount");
            ViewBag.CategoryNameByMaxProductCount = await responseMessage10.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik11
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("https://localhost:7243/api/Statistics/CityNameByMaxProductCount");
            ViewBag.CityNameByMaxProductCount = await responseMessage11.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik12
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:7243/api/Statistics/DifferentCityCount");
            ViewBag.DifferentCityCount = await responseMessage12.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik13
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client13.GetAsync("https://localhost:7243/api/Statistics/EmployeeNameByMaxProductCount");
            ViewBag.EmployeeNameByMaxProductCount = await responseMessage13.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik14
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("https://localhost:7243/api/Statistics/LastProductPrice");
            ViewBag.LastProductPrice = await responseMessage14.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik15
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("https://localhost:7243/api/Statistics/NewestBuildingYear");
            ViewBag.NewestBuildingYear = await responseMessage15.Content.ReadAsStringAsync();
            #endregion

            #region İstatistik16
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client16.GetAsync("https://localhost:7243/api/Statistics/OldestBuildingYear");
            ViewBag.OldestBuildingYear = await responseMessage16.Content.ReadAsStringAsync();
            #endregion
            return View();
        }
    }
}
