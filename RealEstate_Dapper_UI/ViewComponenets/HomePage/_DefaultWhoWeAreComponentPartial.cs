using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.WhoWeAreDetailDtos;

namespace RealEstate_Dapper_UI.ViewComponenets.HomePage
{
    public class _DefaultWhoWeAreComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultWhoWeAreComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var client2 = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7243/api/WhoWeAreDetails");
            var responseMessage2 = await client2.GetAsync("https://localhost:7243/api/Service");

            if (responseMessage.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDto>>(jsonData);
                var values2 = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData2);

                ViewBag.title = values.Select(x => x.Title).FirstOrDefault();
                ViewBag.subtitle = values.Select(x => x.Subtitle).FirstOrDefault();
                ViewBag.description1 = values.Select(x => x.Description1).FirstOrDefault();
                ViewBag.description2 = values.Select(x => x.Description2).FirstOrDefault();

                return View(values2);
            }
            return View();
        }
    }
}
