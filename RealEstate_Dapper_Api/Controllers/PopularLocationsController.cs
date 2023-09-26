using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Repositories.PopularLocationRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPopularLocation()
        {
            var values = await _popularLocationRepository.GetPopularLocationAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            _popularLocationRepository.CreatePopularLocation(createPopularLocationDto);
            return Ok("Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            _popularLocationRepository.UpdatePopularLocation(updatePopularLocationDto);
            return Ok("Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            _popularLocationRepository.DeletePopularLocation(id);
            return Ok("Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIDPopularLocation(int id)
        {
            var value = await _popularLocationRepository.GetByIDPopularLocationAsync(id);
            return Ok(value);
        }
    }
}
