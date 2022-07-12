using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Realpath.NewWebSite.Data.Models
{
    public class CompanyInfo
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        
        public string? logoUrl { get; set; }

        public Address? address { get; set; }

        public ContactDetail? contactDetail { get; set; }
    }
}
