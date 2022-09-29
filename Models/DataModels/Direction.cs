namespace maihelper.Models.DataModels
{
    public class Direction
    {
        public int Id { get; set; }
        public string? Code { get; set; }

        public List<Subject> Subjects { get; set; } = new();
    }
}
