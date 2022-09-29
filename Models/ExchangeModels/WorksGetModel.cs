using maihelper.Models.DataModels;

namespace maihelper.Models.ExchangeModels
{
    public class WorksGetModel
    {
        public WorkType WorkType { get; set; }
        public int SubjectId { get; set; }
        public int PageNumber { get; set; }
    }
}
