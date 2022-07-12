using System.ComponentModel.DataAnnotations;

namespace Realpath.NewWebSite.Data.Models
{
    public class ContactDetail
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? MailAddess { get; set; }
        public string? pOBoxAddress { get; set; }
    }
}
