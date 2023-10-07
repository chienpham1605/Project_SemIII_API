namespace PostOffice.API.Data.Models
{
    public class MoneyServicePrice
    {
        public int id { get; set; }
        public int zone_type_id { get; set; }
        public int money_scope_id { get; set; }
        public float fee { get; set; }

        public ICollection<MoneyScope> MoneyScopes { get; set; }
    }
}
