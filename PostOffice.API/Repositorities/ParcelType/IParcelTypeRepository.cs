
namespace PostOffice.API.Repositories.ParcelType
{
    using Models.DTOs.ParcelType;
    using Models;
    public interface IParcelTypeRepository
    {
        Task<ParcelType> AddParcelType(ParcelTypeCreateDTO parcelTypeCreateDTO);
        Task<ParcelType> UpdateParcelType(ParcelTypeUpdateDTO parcelTypeUpdateDTO);
        Task<List<ParcelType>> GetAllParcelTypes();
    }
}
