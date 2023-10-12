using System.ComponentModel.DataAnnotations;

namespace Models.DTOs.WeightScope
{
    public class WeightScopeUpdateDTO
    {
        public int id { get; set; }
        [Required]
        public float min_weight { get; set; }
        [Required]

        public float max_weight { get; set; }

        public string? description { get; set; }
    }
}
