using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Realpath.NewWebSite.Data.Models
{
    public class Member
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public Designation designation { get; set; }
        public Address address { get; set; }
        public ContactDetail contactDetail { get; set; }

        [DefaultValue(false)]
        public bool isBOD { get; set; }
    }

    
}
