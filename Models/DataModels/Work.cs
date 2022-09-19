using maihelper.Models.Interfaces;

namespace maihelper.Models.DataModels
{
    public class Work : IWithId
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public WorkType WorkType { get; set; }
        public bool IsOnPage { get; set; } = false;
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }

    public enum WorkType
    {
        Ticket = 0,
        LaboratoryWork = 1,
        Note = 2
    }
}
