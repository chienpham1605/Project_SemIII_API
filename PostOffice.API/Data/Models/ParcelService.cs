namespace PostOffice.API.Data.Models
{
    public class ParcelService
    {
        public int service_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }    
        
        public string status { get; set; }

        public int delivery_time { get; set; }

        public ParcelServicePrice ParcelServicePrice { get; set; }
        public ICollection<ParcelOrder> ParcelOrders { get; set; }

    }
}
