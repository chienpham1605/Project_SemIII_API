﻿using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

namespace PostOffice.API.Repositories.ParcelServciePrice
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using PostOffice.API.Data.Context;
    using Models;
    using Models.DTOs.ParcelServicePrice;
    using PostOffice.API.Repositories.ParcelServicePrice;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ServicePriceService : IServicePriceRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ServicePriceService(AppDbContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ParcelServicePrice> AddServicePrice(ServicePriceCreateDTO servicePriceCreateDTO)
        {
            var servicePriceEntity = _mapper.Map<ParcelServicePrice>(servicePriceCreateDTO);

            // Thêm dữ liệu vào cơ sở dữ liệu
            _context.ServicePrices.Add(servicePriceEntity);
            await _context.SaveChangesAsync();
            return servicePriceEntity;
        }


        public async Task<bool> UpdateServicePrice(int id, ServicePriceUpdateDTO servicePriceUpdateDTO)
        {
            var fee = await _context.ServicePrices.SingleOrDefaultAsync(p => p.parcel_price_id == id);

            if (fee == null)
            {
                return false;
            }

            // Update the properties of the product with the values from the DTO
            _mapper.Map(servicePriceUpdateDTO, fee);

            await _context.SaveChangesAsync();

            return true;
        }
    }
    
}
