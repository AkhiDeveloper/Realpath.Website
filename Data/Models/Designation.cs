using System.ComponentModel.DataAnnotations;

namespace Realpath.NewWebSite.Data.Models
{
    public class Designation
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name{ get; set; }
        [Required]
        public Level level { get; set; }
    }

    public enum Level { Senior, Intermediate, Junior, Intern}
}