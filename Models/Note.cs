using System.ComponentModel.DataAnnotations;

namespace maihelper.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string? Theme { get; set; }

        //Добавление отношения один к многим
        public int SubjectID { get; set; }
        public Subject subject { get; set; }
    }
}
