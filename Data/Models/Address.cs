using System.ComponentModel.DataAnnotations;

namespace Realpath.NewWebSite.Data.Models
{
    public class Address
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Province")]
        public string Region { get; set; }

        [Required]
        [Display(Name ="District")]
        public string SubRegion { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

    }
}