using System.ComponentModel.DataAnnotations;

namespace maihelper.Models
{
    public class LaboratoryWork : IWithId
    {
        [Key]
        public int Id { get; set; }
        public int Views { get; set; } = 0;
        public int OptionLab { get; set; } = 0;  //Вариант лабораторной работы
        public string? Theme { get; set; }
        public string? DownloadFile { get; set; }
        public string? Teacher { get; set; }
        public string? Author { get; set; }
        public string? Listing { get; set; }    //Листинг (ссылка на файл)

        //Добавление отношения один к многим
        public int SubjectId { get; set; }
        public Subject subject { get; set; }
    }
}
