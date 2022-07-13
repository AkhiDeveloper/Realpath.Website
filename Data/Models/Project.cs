using System.ComponentModel;
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

        [Required]
        [DefaultValue(0)]
        public ProjectStatus Status { get; set; }
    }

    public enum ProjectStatus
    {
        Unknown,
        Completed,
        Ongoing,
        Future
    }

}
