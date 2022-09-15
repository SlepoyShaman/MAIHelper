using System.ComponentModel.DataAnnotations;

namespace maihelper.Models
{
    public class LaboratoryWork
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FilePath { get; set; }

    }
}
