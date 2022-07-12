using System.ComponentModel.DataAnnotations;

namespace Realpath.NewWebSite.Data.Models
{
    public class Photo
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string title { get; set; }

        public string? Descrition { get; set; }

        [Required]
        public string Url { get; set; }
       
    }
}
