//using maihelper.Data;
//using Microsoft.AspNetCore.Mvc;
//using maihelper.Models.ExchangeModels;
//using maihelper.Models.DataModels;
//using maihelper.Models.Interfaces;

//namespace maihelper.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class HomeController : ControllerBase
//    {
//        private readonly IRepository _repository;
//        private readonly ApplicationDbContext _context;
//       public HomeController(IRepository repository, ApplicationDbContext context)
//        {
//            _repository = repository;
//            _context = context;
//        }

//        [HttpPost]
//        public IActionResult ViewHome()
//        {
//            var ReturnModel = new HomePageRetModel()
//            {
//                NewLaboratoryWorks = GetLastElements<LaboratoryWork>(LabsOnPageCount),
//                NewNots = GetLastElements<Note>(NotesOnPageCount),
//                ActualTickets = GetLastElements<Ticket>(TicketsOnPageCount)
//            };

//            return Ok(ReturnModel);
//        }

//        private IEnumerable<T> GetLastElements<T>(int quantity) where T : class, IWithId
//        {
//            return _repository.GetAll<T>().OrderByDescending(x => x.Id).Take(quantity);
//        }

//            work.IsOnPage = NewWorkStatus;

//            _repository.AddNewItem<Work>(work);
//            return Ok();
//        }    
//    }
//}
