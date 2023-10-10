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

       
        //[HttpPut]
        //[Route("UpdateMoneyService")]
        //public async Task<List<MoneyServicePriceDTO>>UpdateMoneyServicePriceDTO(MoneyServicePriceDTO moneyServicePriceDTO)
        //{
        //    MoneyServicePrice UDMSP = await _context.MoneyServices.FirstAsync(moneyServicePriceDTO.id){
        //        if(UDMSP != null)
        //        {
        //            UDMSP.money_scope_id = moneyServicePriceDTO.money_scope_id;
        //            UDMSP.zone_type_id = moneyServicePriceDTO.zone_type_id;
        //            UDMSP.fee = moneyServicePriceDTO.fee;

        //            await _context.SaveChangesAsync();
        //        };
        //        List<MoneyServicePriceDTO> UpdateMoneyService = await GetMoneyServiceDTOList();
        //        return UpdateMoneyService;
        //    }
        //}

        // POST: api/MoneyService
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MoneyServicePriceDTO>> PostMoneyServicePriceDTO(MoneyServicePriceDTO moneyServicePriceDTO)
        {
          if (_context.MoneyServicePriceDTO == null)
          {
              return Problem("Entity set 'AppDbContext.MoneyServicePriceDTO'  is null.");
          }
            _context.MoneyServicePriceDTO.Add(moneyServicePriceDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMoneyServicePriceDTO", new { id = moneyServicePriceDTO.id }, moneyServicePriceDTO);
        }

        // DELETE: api/MoneyService/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMoneyServicePriceDTO(int id)
        {
            if (_context.MoneyServicePriceDTO == null)
            {
                return NotFound();
            }
            var moneyServicePriceDTO = await _context.MoneyServicePriceDTO.FindAsync(id);
            if (moneyServicePriceDTO == null)
            {
                return NotFound();
            }

            _context.MoneyServicePriceDTO.Remove(moneyServicePriceDTO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MoneyServicePriceDTOExists(int id)
        {
            return (_context.MoneyServicePriceDTO?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
