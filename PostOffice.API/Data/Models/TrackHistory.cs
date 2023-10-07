namespace PostOffice.API.Data.Models
{
    public class TrackHistory
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public string new_status { get; set; }
        public DateTime update_time { get; set; }
        public string new_location { get; set; }
        public string employee_id { get; set; }
    }
}
