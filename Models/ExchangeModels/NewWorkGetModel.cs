using maihelper.Models.DataModels;

namespace maihelper.Models.ExchangeModels
{
    public class NewWorkGetModel
    {
        public string Title { get; set; }
        public WorkType WorkType { get; set; }
        public int SubjectId { get; set; }
    }
}
