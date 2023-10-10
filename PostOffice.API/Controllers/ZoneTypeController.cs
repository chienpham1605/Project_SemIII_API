using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PostOffice.API.Data.Context;
using PostOffice.API.Data.DTOs.ZoneType;

namespace PostOffice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZoneTypeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ZoneTypeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ZoneType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZoneTypeDTO>>> GetZoneTypeDTO()
        {
          if (_context.ZoneTypeDTO == null)
          {
              return NotFound();
          }
            return await _context.ZoneTypeDTO.ToListAsync();
        }

        // GET: api/ZoneType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ZoneTypeDTO>> GetZoneTypeDTO(int id)
        {
          if (_context.ZoneTypeDTO == null)
          {
              return NotFound();
          }
            var zoneTypeDTO = await _context.ZoneTypeDTO.FindAsync(id);

            if (zoneTypeDTO == null)
            {
                return NotFound();
            }

            return zoneTypeDTO;
        }

        // PUT: api/ZoneType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZoneTypeDTO(int id, ZoneTypeDTO zoneTypeDTO)
        {
            if (id != zoneTypeDTO.id)
            {
                return BadRequest();
            }

            _context.Entry(zoneTypeDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZoneTypeDTOExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ZoneType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ZoneTypeDTO>> PostZoneTypeDTO(ZoneTypeDTO zoneTypeDTO)
        {
          if (_context.ZoneTypeDTO == null)
          {
              return Problem("Entity set 'AppDbContext.ZoneTypeDTO'  is null.");
          }
            _context.ZoneTypeDTO.Add(zoneTypeDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZoneTypeDTO", new { id = zoneTypeDTO.id }, zoneTypeDTO);
        }

        // DELETE: api/ZoneType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZoneTypeDTO(int id)
        {
            if (_context.ZoneTypeDTO == null)
            {
                return NotFound();
            }
            var zoneTypeDTO = await _context.ZoneTypeDTO.FindAsync(id);
            if (zoneTypeDTO == null)
            {
                return NotFound();
            }

            _context.ZoneTypeDTO.Remove(zoneTypeDTO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ZoneTypeDTOExists(int id)
        {
            return (_context.ZoneTypeDTO?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
