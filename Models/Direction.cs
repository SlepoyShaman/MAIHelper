using maihelper.Models.DataModels;
using maihelper.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace maihelper.Models
{
    public class Direction : IWithId
    {
        [Key]
        public int Id { get; set; }
        public string? Code { get; set; }

        //Добавление отношения многие к многим
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
