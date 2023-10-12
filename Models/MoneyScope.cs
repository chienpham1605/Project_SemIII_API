﻿namespace Models
{
    public class MoneyScope
    {
        public int id { get; set; }
        public float min_value { get; set; }
        public float max_value { get; set;}
        public string description { get; set; }


        public ICollection<MoneyServicePrice> MoneyServicePrice { get; set; }
    }
}
