using Microsoft.EntityFrameworkCore;
using PostOffice.API.Data.Context;
using PostOffice.API.Data.DTOs.MoneyOrder;
using PostOffice.API.Data.Models;
using PostOffice.API.Repositories.MoneyOrder;
using System.Collections.Generic;

namespace PostOffice_Server.Services
{
    public class MoneyOrderService : IMoneyOrder
    {
        private readonly AppDbContext _context;
        public MoneyOrderService(AppDbContext context)
        {
            _context = context;

        }

        public async Task<List<MoneyOrderCreateDTO>> ListMoneyOrderDTO()
        {
            List<MoneyOrderCreateDTO> listDTO = new List<MoneyOrderCreateDTO>();
            var list = await _context.MoneyOrders.ToListAsync();
            foreach (MoneyOrder item in list)
            {
                MoneyOrderCreateDTO dto = new MoneyOrderCreateDTO()
                {
                    id = item.id,
                    user_id = item.user_id,
                    sender_name = item.sender_name,
                    sender_pincode = item.sender_pincode,
                    sender_address = item.sender_address,
                    sender_phone = item.sender_phone,
                    sender_email = item.sender_email,
                    sender_national_identity_number = item.sender_national_identity_number,

                    receiver_name = item.receiver_name,
                    receiver_pincode = item.receiver_pincode,
                    receiver_phone = item.receiver_phone,
                    receiver_address = item.receiver_address,
                    receiver_email = item.receiver_email,
                    receiver_national_identity_number = item.receiver_national_identity_number,

                    transfer_value = item.transfer_value,
                    transfer_fee = item.transfer_fee,
                   
                    total_charge = item.total_charge,
                };
                listDTO.Add(dto);
            }


            return listDTO;
        }

    

        async Task<MoneyOrderCreateDTO> IMoneyOrder.CreateMoneyOrder(MoneyOrderCreateDTO moneyOrder)
        {
            MoneyOrder MO = new MoneyOrder()
            {
                id = moneyOrder.id,
                user_id = moneyOrder.user_id,
                sender_name = moneyOrder.sender_name,
                sender_pincode = moneyOrder.sender_pincode,
                sender_address = moneyOrder.sender_address,
                sender_phone = moneyOrder.sender_phone,
                sender_email = moneyOrder.sender_email,
                sender_national_identity_number = moneyOrder.sender_national_identity_number,

                receiver_name = moneyOrder.receiver_name,
                receiver_pincode = moneyOrder.receiver_pincode,
                receiver_phone = moneyOrder.receiver_phone,
                receiver_address = moneyOrder.receiver_address,
                receiver_email = moneyOrder.receiver_email,
                receiver_national_identity_number = moneyOrder.receiver_national_identity_number,

                transfer_value = 0, //chua xong, mot coi lai
                transfer_fee = 0,  //chua xong, mot coi lai
                MoneyServicePrice = _context.MoneyServices.FirstOrDefault(),
                total_charge = 0, //chua xong, mot coi lai

            };

            await _context.MoneyOrders.AddAsync(MO);
            await _context.SaveChangesAsync();
            return moneyOrder;
        }


    }
}
