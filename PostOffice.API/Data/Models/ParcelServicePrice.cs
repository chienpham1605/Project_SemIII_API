using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostOffice.API.Data.Models
{
    public class ParcelServicePrice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int parcel_price_id { get; set; }
        public int zone_type_id { get; set; }
        public int service_id { get; set; }
        public int parcel_type_id { get; set; }
        public int scope_weight_id { get; set; }
        public float service_price { get; set; }

        public ICollection<ZoneType> ZoneTypes { get; set; }
        public ICollection<ParcelService> ParcelServices { get; set; }
        public ICollection<ParcelType> ParcelTypes { get; set; }

        public ICollection<WeightScope> WeightScopes { get; set; }  
        
    }
}
