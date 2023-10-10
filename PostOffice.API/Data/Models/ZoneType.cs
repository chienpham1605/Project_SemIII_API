namespace PostOffice.API.Data.Models
{
    public class ZoneType
    {
        public int id { get; set; }
        public string zone_description { get; set; }

        public ParcelServicePrice ParcelServicePrice { get; set; }
        public MoneyServicePrice MoneyServicePrice { get; set; }
    }
}
