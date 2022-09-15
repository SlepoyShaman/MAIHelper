using System.ComponentModel.DataAnnotations;

namespace maihelper.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }

        //Добавление отношений много к многим
        public List<Direction> Directions { get; set; } = new List<Direction>();
        public List<LaboratoryWork> LaboratoryWorks { get; set; } = new List<LaboratoryWork>();
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
