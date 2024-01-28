using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class TipCalculator
    {
        // Required attribute to ensure CostofMeale is provided
        [Required(ErrorMessage = "Cost of meal is required.")]
        // Range attribute to specify the valid range for CostofMeale
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid number greater than 0.")]
        public decimal? CostofMeale { get; set; }

        // Calculated property for 15% tip
        public decimal CostofMeale1 => CostofMeale.GetValueOrDefault() * 0.15m;

        // Calculated property for 20% tip
        public decimal CostofMeale2 => CostofMeale.GetValueOrDefault() * 0.20m;

        // Calculated property for 25% tip
        public decimal CostofMeale3 => CostofMeale.GetValueOrDefault() * 0.25m;
    }
}
