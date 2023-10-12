﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ParcelService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int service_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }    
        
        public string status { get; set; }

        public int delivery_time { get; set; }

        public ICollection<ParcelServicePrice> ParcelServicePrice { get; set; }
        public ICollection<ParcelOrder> ParcelOrders { get; set; }

    }
}
