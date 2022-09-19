using maihelper.Models.Interfaces;

namespace maihelper.Models.DataModels
{
    public class Subject : IWithId
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<Direction> Directions { get; set; } = new();
        public List<Work> Works { get; set; } = new();
    }
}
