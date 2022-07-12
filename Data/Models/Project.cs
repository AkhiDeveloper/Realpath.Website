using System.ComponentModel.DataAnnotations;

namespace Realpath.NewWebSite.Data.Models
{
    public class Project
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public string? description { get; set; }
    }
}
