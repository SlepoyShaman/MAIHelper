<<<<<<< HEAD
﻿//using maihelper.Data;
//using Microsoft.AspNetCore.Mvc;
//using maihelper.Models.ExchangeModels;
//using maihelper.Models.DataModels;
//using maihelper.Models.Interfaces;
=======
﻿using maihelper.Data;
using Microsoft.AspNetCore.Mvc;
using maihelper.Models.ExchangeModels;
using maihelper.Models.DataModels;
>>>>>>> c3e492c95c672736e3b155ebfc80a8106bcc1f7a

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

<<<<<<< HEAD
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
=======
        [HttpPost]
        public IActionResult ViewHome()
        {
            var result = _repository.GetAll<Work>().Where(w => w.IsOnPage).Select(w => new HomePageRetModel() { 
                Title = w.Subject.Title,
                SubjectId = w.SubjectId,
                WorkType = w.WorkType
            });
            return Ok(result);
        }
    }
}
>>>>>>> c3e492c95c672736e3b155ebfc80a8106bcc1f7a
