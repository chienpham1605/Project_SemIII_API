namespace PostOffice.API.Data.Models
{
    public class ParcelService
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }    
        
        public string status { get; set; }

        public int delivery_time { get; set; }

        public ParcelServicePrice Price { get; set; }

    }
}
