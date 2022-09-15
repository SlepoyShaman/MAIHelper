using System.ComponentModel.DataAnnotations;

namespace maihelper.Models
{
    public class Direction
    {
        [Key]
        public int Id { get; set; }
        public string? Code { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
