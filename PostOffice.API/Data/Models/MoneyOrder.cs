namespace PostOffice.API.Data.Models
{
    public class MoneyOrder
    {
        public int id { get; set; }
        //personal infor
        public string user_id { get; set; }

        public string sender_name { get; set; }
        public string sender_pincode { get; set; }
        public string sender_address { get; set; }
        public string sender_phone { get; set; }
        public string sender_email { get; set; }
        public string sender_national_identity_number { get; set; }

        public string receiver_name { get; set; }
        public string receiver_pincode { get; set; }
        public string receiver_address { get; set; }
        public string receiver_phone { get; set; }
        public string receiver_email { get; set; }
        public string receiver_national_identity_number { get; set; }

        //money order infor
        public string transfer_status { get; set; }        
        public string note { get; set; }
        public float transfer_value { get; set; }
        public float transfer_fee { get; set; }

        //service infor
        public int service_id { get; set; }
        public int parcel_type_id { get; set; }

        //fee payment infor
        public string payer { get; set; }           

        //datetime infor
        public DateTime send_date { get; set; }
        public DateTime receive_date { get; set; }

        //charge infor         
        public float total_charge { get; set; }

        
        

        public Pincode Pincode { get; set; }
        public MoneyServicePrice MoneyServicePrice { get; set; }
    }
}
