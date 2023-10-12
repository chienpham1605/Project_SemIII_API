
namespace PostOffice.API.Repositories.ParcelOrder
{
    using Models.DTOs.ParcelOrder;
    using Models;
    public interface IParcelOrderRepository
    {
        Task<ParcelOrder> AddParcelOrderAsync(ParcelOrderCreateDTO parcelOrderDTO);
        Task<bool> UpdateParcelOrder(int id, ParcelOrderUpdateDTO parcelOrderUpdateDTO);
        Task<ParcelOrderBase> GetParcelOrderById(int id);
    }
}
