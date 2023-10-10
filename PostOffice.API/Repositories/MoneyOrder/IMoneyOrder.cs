using PostOffice.API.Data.DTOs.MoneyOrder;
using PostOffice.API.Data.Models;

namespace PostOffice.API.Repositories.MoneyOrder
{
    public interface IMoneyOrder
    {

        Task<List<MoneyOrderCreateDTO>> ListMoneyOrderDTO();


        Task<MoneyOrderCreateDTO> CreateMoneyOrder(MoneyOrderCreateDTO moneyOrder);
    }
}