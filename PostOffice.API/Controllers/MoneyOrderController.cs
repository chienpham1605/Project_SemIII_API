using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostOffice.API.Data.Models;
using PostOffice.API.Data.DTOs.MoneyOrder;
using PostOffice.API.Repositories.MoneyOrder;

namespace PostOffice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyOrderController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IMoneyOrder _moneyOrder;
        public MoneyOrderController(IConfiguration configuration, IMoneyOrder moneyOrder)
        {
            _configuration = configuration;
            _moneyOrder = moneyOrder;
        }

        [HttpGet]
        [Route("ListMoneyOrder")]
        public async Task<List<MoneyOrderCreateDTO>> ListMoneyOrderDTO()
        {

            return await _moneyOrder.ListMoneyOrderDTO();
        }

        [HttpPost]
        [Route("createMoneyOrders")]
        public async Task<MoneyOrderCreateDTO> CreateMoneyOrder(MoneyOrderCreateDTO moneyOrder)
        {


            return await _moneyOrder.CreateMoneyOrder(moneyOrder);
        }


    }
}
