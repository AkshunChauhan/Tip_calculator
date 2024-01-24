
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models {
    public class TipCalculator
    {
        [Required(ErrorMessage = "Cost of meal is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid number greater than 0.")]
        public decimal? CostofMeale { get; set; }

        public decimal CostofMeale1 => CostofMeale.GetValueOrDefault() * 0.15m;
        public decimal CostofMeale2 => CostofMeale.GetValueOrDefault() * 0.20m;
        public decimal CostofMeale3 => CostofMeale.GetValueOrDefault() * 0.25m;
    }

}
