using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TrackHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int track_id { get; set; }
        public int order_id { get; set; }
        public string new_status { get; set; }
        public DateTime update_time { get; set; }
        public string new_location { get; set; }
        public string employee_id { get; set; }
        public AppUser Employee { get; set; } 
        public ParcelOrder ParcelOrder { get; set; }
    }
}
