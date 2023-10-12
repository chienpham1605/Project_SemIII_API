namespace PostOffice.API.Repositories.ParcelServicePrice
{
    using Models;
    using Models.DTOs.ParcelServicePrice;

    public interface IServicePriceRepository
    {
        Task<ParcelServicePrice> AddServicePrice(ServicePriceCreateDTO servicePriceCreateDTO);
        Task<bool> UpdateServicePrice(int id, ServicePriceUpdateDTO servicePriceUpdateDto);
    }
}
