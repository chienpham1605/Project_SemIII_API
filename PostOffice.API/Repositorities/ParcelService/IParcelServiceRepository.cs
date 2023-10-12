
namespace PostOffice.API.Repositories.ParcelService
{
    using Models.DTOs.ParcelService;
    using Models;
    public interface IParcelServiceRepository
    {
        Task<ParcelService> AddParcelService(ParcelServiceCreateDTO parcelServiceCreateDTO);
        Task<bool> UpdateParcelService(int id, ParcelServiceUpdateDTO parcelServiceUpdateDTO);
        Task<ParcelServiceBaseDTO> GetParcelServiceList();
    }
}
