﻿using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace PostOffice.API.Data.Models
{
    public class Pincode
    {
       
        public string pincode { get; set; }
        public string city_name { get; set; }
        public int area_id { get; set;}
        public Area Area { get; set; }

        public ICollection<OfficeBranch> OfficeBranches { get; set; }
        public ICollection<ParcelOrder> ParcelOrders { get; set; }
    }
}
