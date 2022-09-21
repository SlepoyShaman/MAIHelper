using maihelper.Models.DataModels;

namespace maihelper.Models.ExchangeModels
{
    public class RemoveWorkGetModel
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public WorkType WorkType { get; set; }
    }
}
