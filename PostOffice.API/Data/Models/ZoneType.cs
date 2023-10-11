using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostOffice.API.Data.Models
{
    public class ZoneType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string zone_description { get; set; }
        public ParcelServicePrice ParcelServicePrice { get; set; }
        public MoneyServicePrice MoneyServicePrice { get; set; }
    }
}
