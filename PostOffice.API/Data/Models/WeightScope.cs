namespace PostOffice.API.Data.Models
{
    public class WeightScope
    {
        public int id { get; set; }
        public float min_weight { get; set; }
        public float max_weight { get; set;}
        public string description { get; set; }
        public ParcelServicePrice Price { get; set; }
    }
}
