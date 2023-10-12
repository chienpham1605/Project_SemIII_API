using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
namespace PostOffice.API.Repositories.ParcelService
{
    using Models;
    using PostOffice.API.Data.Context;
    using Models.DTOs.ParcelOrder;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System;
    using Models.DTOs.ParcelService;
    using AutoMapper;
    using Models.DTOs.ParcelType;

    public class ParcelServiceService : IParcelServiceRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public ParcelServiceService(AppDbContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ParcelServiceBaseDTO> GetParcelServiceList()
        {
            var parcelservices = _context.ParcelServices.ToList();
            var parcelserviceDtos = _mapper.Map<ParcelServiceBaseDTO>(parcelservices);

            return parcelserviceDtos;
        }

        public async Task<ParcelService> AddParcelService(ParcelServiceCreateDTO parcelServiceCreateDTO)
        {
            var parcelService = _mapper.Map<ParcelServiceCreateDTO, ParcelService>(parcelServiceCreateDTO);
            _context.ParcelServices.Add(parcelService);
            await _context.SaveChangesAsync();
            return parcelService;
        }

        public async Task<bool> UpdateParcelService(int id, ParcelServiceUpdateDTO parcelServiceUpdateDTO)
        {
            var parcelservice = _context.ParcelServices.SingleOrDefault(p => p.service_id == id);
            if (parcelservice == null)
            {
                return false;
            }
            _mapper.Map(parcelServiceUpdateDTO, parcelservice);

            _context.SaveChanges();

            return true;
        }
    }
}
