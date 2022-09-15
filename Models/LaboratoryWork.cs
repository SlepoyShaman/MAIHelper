using System.ComponentModel.DataAnnotations;

namespace maihelper.Models
{
    public class LaboratoryWork
    {
        [Key]
        public int Id { get; set; }

        public int Views { get; set; } = 0;
        public int OptionLab { get; set; } = 0;  //Вариант лабораторной работы
        public string? Name { get; set; }
        public string? FilePath { get; set; }
        public string? DownloadFile { get; set; }
        public string? Teacher { get; set; }
        public string? Author { get; set; }
        public string? Listing { get; set; }    //Листинг (ссылка на path)

    }
}
