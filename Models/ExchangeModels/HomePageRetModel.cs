namespace maihelper.Models.ExchangeModels
{
    public class HomePageRetModel
    {
        public IEnumerable<LaboratoryWork> NewLaboratoryWorks { get; set; }
        public IEnumerable<Note> NewNots { get; set; }
        public IEnumerable<Ticket> ActualTickets { get; set; }
        
    }
}
