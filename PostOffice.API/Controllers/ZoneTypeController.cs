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



      

     

    
    }
}
