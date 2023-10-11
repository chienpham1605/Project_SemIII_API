using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PostOffice.API.Data.Context;
using PostOffice.API.Data.DTOs.MoneyServicePriceDTO;
using PostOffice.API.Data.Models;

namespace PostOffice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyServiceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MoneyServiceController(AppDbContext context)
        {
            _context = context;
        }

        protected async Task<List<MoneyServicePriceDTO>> GetMoneyServiceDTOList()
        {
            List<MoneyServicePriceDTO> ListMSP = new List<MoneyServicePriceDTO>();
            var list = await _context.MoneyServices.ToListAsync();
            foreach (var item in list)
            {
                MoneyServicePriceDTO money = new MoneyServicePriceDTO()
                {
                    id = item.id,
                    zone_type_id = item.zone_type_id,
                    money_scope_id = item.money_scope_id,

                };
                ListMSP.Add(money);
            }
            return ListMSP;
        }


        [HttpPut]
        [Route("UpdateMoneyService")]
        public async Task<bool> UpdateMoneyServicePriceDTO(MoneyServicePriceDTO moneyServicePriceDTO)
        {
            MoneyServicePrice? UDMSP = await _context.MoneyServices.FindAsync(moneyServicePriceDTO.id);
            bool isUpdated = false;
            if (UDMSP != null)
            {
                UDMSP.money_scope_id = moneyServicePriceDTO.money_scope_id;
                UDMSP.zone_type_id = moneyServicePriceDTO.zone_type_id;
                UDMSP.fee = moneyServicePriceDTO.fee;

                await _context.SaveChangesAsync();
                isUpdated = true;
            };
            //List<MoneyServicePriceDTO> UpdateMoneyService = await GetMoneyServiceDTOList();

            return isUpdated;

        }


    }
}
