﻿namespace PostOffice.API.Data.DTOs.MoneyScope
{
    public class MoneyScopeDTO
    {
        public int id { get; set; }
        public float min_value { get; set; }
        public float max_value { get; set; }
        public string? description { get; set; }

    }
}
