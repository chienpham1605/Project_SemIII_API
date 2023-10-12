namespace Models
{
    public class ZoneType
    {
        public int id { get; set; }
        public string zone_description { get; set; }

        public ICollection<ParcelServicePrice> ParcelServicePrice { get; set; }
        public ICollection<MoneyServicePrice> MoneyServicePrice { get; set; }
    }
}
