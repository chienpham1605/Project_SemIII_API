using System.ComponentModel.DataAnnotations;

namespace Models.DTOs.WeightScope
{
    public class WeightScopeCreateDTO
    {
        [Required]
        public float min_weight { get; set; }
        [Required]

        public float max_weight { get; set; }
        [Required]

        public string? description { get; set; }
    }
}
