﻿using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Repositories.ServiceRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetServiceList()
        {
            var values = await _serviceRepository.GetAllServiceAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            _serviceRepository.CreateService(createServiceDto);
            return Ok(" eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            _serviceRepository.DeleteService(id);
            return Ok("başarılı bir şekilde silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            _serviceRepository.UpdateService(updateServiceDto);
            return Ok(" Güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await _serviceRepository.GetService(id);
            return Ok(value);
        }
    }
}
