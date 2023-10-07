namespace PostOffice.API.Data.Models
{
    public class ParcelType
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float max_length { get; set; }
        public float max_width { get; set; }
        public float max_height { get; set; }
        public float max_weight { get; set; }
        public float over_dimension_rate { get; set; }

        public ParcelServicePrice Price { get; set; }
    }
}
