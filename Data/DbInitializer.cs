using maihelper.Models.DataModels;

namespace maihelper.Data
{
    public  static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Directions.Any()) { return; }

            Direction ProgEng = new Direction() { Code = "09.03.04" };
            Direction ICE = new Direction() { Code = "09.03.02" };
            context.Directions.AddRange(ProgEng, ICE);

            Subject Proga = new Subject() { Title = "программирование" };
            Subject DiscretMath = new Subject() { Title = "Дискретная математика" };
            Subject subject = new Subject() { Title = "Схемотехника" };
            context.Subjects.AddRange(Proga, DiscretMath, subject);

            ProgEng.Subjects.Add(Proga);
            ProgEng.Subjects.Add(DiscretMath);
            ICE.Subjects.Add(Proga);
            ICE.Subjects.Add(DiscretMath);
            context.SaveChanges();

            var Works = new Work[] {
                new Work()
                {
                    Title = "Сортировка массива",
                    WorkType = WorkType.LaboratoryWork,
                    IsOnPage = true,
                    Subject = Proga
                },

                new Work()
                {
                    Title = "Строковые данные",
                    WorkType = WorkType.LaboratoryWork,
                    IsOnPage = false,
                    Subject = Proga
                },

                new Work()
                {
                    Title = "Поиск кратчайших маршрутов в графе",
                    WorkType = WorkType.LaboratoryWork,
                    IsOnPage = true,
                    Subject = DiscretMath
                },

                new Work()
                {
                    Title = "Понятие алгоритма",
                    WorkType = WorkType.Note,
                    IsOnPage = true,
                    Subject = Proga
                },

                new Work()
                {
                    Title = "Понятие множества",
                    WorkType = WorkType.Note,
                    IsOnPage = true,
                    Subject = DiscretMath
                },

                new Work()
                {
                    Title = "Билеты 1 сем",
                    WorkType = WorkType.Ticket,
                    IsOnPage = true,
                    Subject = DiscretMath
                },

                new Work()
                {
                    Title = "Билеты 1 сем",
                    WorkType = WorkType.Ticket,
                    IsOnPage = true,
                    Subject = Proga
                }

            };

            context.Works.AddRange(Works);
            context.SaveChanges();
            
        }
    }
}
