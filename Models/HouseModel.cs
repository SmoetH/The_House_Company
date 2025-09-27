using System.ComponentModel.DataAnnotations;

namespace house_company.Models
{
    public class HouseModel
    {
        // Add [Required] attribute for validation
        [Required(ErrorMessage = "House Type is mandatory.")]
        public string HouseType { get; set; }

        // Add [Required] attribute for validation
        [Required(ErrorMessage = "House Location must be provided.")]
        public string HouseLocation { get; set; }
    }
}
