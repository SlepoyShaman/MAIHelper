using maihelper.Models;

namespace maihelper.Data
{
    public static class DbInitializer
    {
        public static void  Initialize(ApplicationDbContext context)
        {
            if (context.Directions.Any())
            {
                return;
            }
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Direction ProgEng = new Direction() { Code = "09.03.04" };
            Direction ICE = new Direction() { Code = "09.03.02" };
            context.Directions.AddRange(ProgEng, ICE);

            Subject Programming = new Subject() { Title = "Программирование" };
            Subject DiscretMath = new Subject() { Title = "Дискретная математика" };
            context.Subjects.AddRange(Programming, DiscretMath);
            

            ProgEng.Subjects.Add(Programming);
            ProgEng.Subjects.Add(DiscretMath);
            ICE.Subjects.Add(Programming);
            ICE.Subjects.Add(DiscretMath);
            context.SaveChanges();

            LaboratoryWork FirstLab = new LaboratoryWork()
            {
                Views = 0,
                OptionLab = 1,
                Theme = "Вычисление суммы бесконечного числового ряда",
                Teacher = "Чечиков Ю.Б.",
                Author = "Denis",
                Listing = "./path",
                subject = Programming
            };

            LaboratoryWork SecondLab = new LaboratoryWork()
            {
                Views = 0,
                OptionLab = 1,
                Theme = "Табулирование функций",
                Teacher = "Чечиков Ю.Б.",
                Author = "SlepoyShaman",
                Listing = "./path",
                subject = Programming
            };
            context.LaboratoryWorks.AddRange(FirstLab, SecondLab);
            context.SaveChanges();

            Ticket ProgaFirst = new Ticket() { Theme = "Понятие алгоритма", subject = Programming };
            Ticket ProgaSecond = new Ticket() { Theme = "Понятие языка программирования", subject = Programming };
            context.Tickets.AddRange(ProgaFirst, ProgaSecond);
            context.SaveChanges();

            Note ProgaLectOne = new Note() { Theme = "Определение алгоритма и первая лабораторная работа", subject = Programming };
            Note ProgaLectTwo = new Note() { Theme = "Указатели на массивы и функции", subject = Programming };
            context.Notes.AddRange(ProgaLectOne, ProgaLectTwo);
            context.SaveChanges();
        }
    }
}
