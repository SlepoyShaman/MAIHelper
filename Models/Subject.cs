using System.ComponentModel.DataAnnotations;

namespace maihelper.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public List<Direction> Directions { get; set; } = new List<Direction>();
    }
}
