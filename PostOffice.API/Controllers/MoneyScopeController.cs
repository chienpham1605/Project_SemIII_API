using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PostOffice.API.Data.Context;
using PostOffice.API.Data.DTOs.MoneyScope;
using PostOffice.API.Data.Models;

namespace PostOffice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyScopeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MoneyScopeController(AppDbContext context)
        {
            _context = context;
        }
        protected async Task<List<MoneyScopeDTO>> GetMoneyScopeDTOList()
        {
            List<MoneyScopeDTO> ListMSDTO = new List<MoneyScopeDTO>();
            var list = await _context.MoneyScopes.ToListAsync();
            foreach (var item in list)
            {
                MoneyScopeDTO dto = new MoneyScopeDTO()
                {
                    id = item.id,
                    min_value = item.min_value,
                    max_value = item.max_value,
                    description = item.description,
                };
                ListMSDTO.Add(dto);
            }
            return ListMSDTO;
        }
        [HttpGet]
        [Route("GetMoneyScope")]
        public async Task<List<MoneyScopeDTO>> GetMoneyScopeDTO()
        {
            return await GetMoneyScopeDTOList();
        }

        [HttpPut]
        [Route("UpdateMoneyScope")]
        public async Task<List<MoneyScopeDTO>> UpdateMoneyScopeDTO(MoneyScopeDTO moneyScopeDTO)
        {


            MoneyScope UDMS = await _context.MoneyScopes.FindAsync(moneyScopeDTO.id);
            if (UDMS != null)
            {
                UDMS.min_value = moneyScopeDTO.min_value;
                UDMS.max_value = moneyScopeDTO.max_value;
                UDMS.description = moneyScopeDTO.description;

                await _context.SaveChangesAsync();


            };
            List<MoneyScopeDTO> UpdateMoneyScope = await GetMoneyScopeDTOList();
            return UpdateMoneyScope;
        }


        //[HttpPost]
        //public async Task<MoneyScopeDTO> PostMoneyScopeCreateDTO(MoneyScopeDTO moneyScope)
        //{
        //    //List<MoneyScopeCreateDTO> ListMS = new List<MoneyScopeCreateDTO>();


        //    MoneyScope MS = new MoneyScope()
        //    {
        //        id = moneyScope.id,
        //        min_value = moneyScope.min_value,
        //        max_value = moneyScope.max_value,
        //        description = moneyScope.description,

        //    };

        //    await _context.MoneyScopes.AddAsync(MS);
        //    await _context.SaveChangesAsync();

        //    return moneyScope;
        //}

        //// DELETE: api/MoneyScopeCreate/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteMoneyScopeCreateDTO(int id)
        //{
        //    if (_context.MoneyScopeCreateDTO == null)
        //    {
        //        return NotFound();
        //    }
        //    var moneyScopeCreateDTO = await _context.MoneyScopeCreateDTO.FindAsync(id);
        //    if (moneyScopeCreateDTO == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.MoneyScopeCreateDTO.Remove(moneyScopeCreateDTO);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool MoneyScopeCreateDTOExists(int id)
        //{
        //    return (_context.MoneyScopeCreateDTO?.Any(e => e.id == id)).GetValueOrDefault();
        //}

    }
}
