using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Area
    {
        [Key]
        public int id { get; set; }
        public string area_name { get; set; }
        public ICollection<Pincode>? Pincodes { get; set; }
    }
}
