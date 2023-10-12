using System.ComponentModel.DataAnnotations;

namespace PostOffice.API.Data.Models
{
    public class Area
    {
        [Key]
        public int id { get; set; } 
        public string area_name { get; set; }
        public ICollection<Pincode>? Pincodes { get; set; }

     
    }
}
