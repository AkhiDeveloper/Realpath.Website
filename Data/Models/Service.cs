using System.ComponentModel.DataAnnotations;

namespace Realpath.NewWebSite.Data.Models
{
    public class Service
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string? Description { get; set; }
        public IList<Service>? SubServices { get; set; }       
    }
}
