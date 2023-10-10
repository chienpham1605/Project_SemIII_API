namespace PostOffice.API.Data.DTOs.MoneyServicePriceDTO
{
    public class MoneyServicePriceDTO
    {

        public int id { get; set; }
        public int zone_type_id { get; set; }
        public int money_scope_id { get; set; }
        public float fee { get; set; }
    }
}
