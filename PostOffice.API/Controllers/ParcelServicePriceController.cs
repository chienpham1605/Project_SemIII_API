using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTOs.ParcelService;
using Models.DTOs.ParcelServicePrice;
using Models.DTOs.ParcelType;
using PostOffice.API.Repositories.ParcelServicePrice;

namespace PostOffice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParcelServicePriceController : ControllerBase
    {
        private readonly IServicePriceRepository _repository;
        public ParcelServicePriceController(IServicePriceRepository repository) 
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> AddServicePrice([FromBody] ServicePriceCreateDTO servicePriceCreateDTO)
        {
            await _repository.AddServicePrice(servicePriceCreateDTO);
            return Ok(servicePriceCreateDTO);

        }
        [HttpPut]
        public async Task<IActionResult> UpdateServicePrice(int id,[FromBody] ServicePriceUpdateDTO servicePriceUpdateDTO)
        {
            var feeUpdated = await _repository.UpdateServicePrice(id, servicePriceUpdateDTO);

            if (!feeUpdated)
            {
                return NotFound();
            }

            return NoContent();

        }
    }
}
