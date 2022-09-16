using maihelper.Data;
using System.Collections.Generic;
using maihelper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using maihelper.Models.ExchangeModels;

namespace maihelper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly Repository _repository;
        public HomeController(Repository repository)
        {
            _repository = repository;
        }

        private int LabsOnPageCount = 2;
        private int NotesOnPageCount = 2;
        private int TicketsOnPageCount = 7;

        [HttpPost]
        public IActionResult ViewIndexPage()
        {
            var ReturnModel = new HomePageRetModel()
            {
                NewLaboratoryWorks = GetLastElements<LaboratoryWork>(LabsOnPageCount),
                NewNots = GetLastElements<Note>(NotesOnPageCount),
                ActualTickets = GetLastElements<Ticket>(TicketsOnPageCount)
            };

            return Ok(ReturnModel);
        }

        private List<T> GetLastElements<T>(int quantity) where T : class, IWithId
        {
            int lastIndex = _repository.GetAll<T>().Last().Id;
            return _repository.GetAll<T>().Where(x => x.Id > lastIndex - quantity).ToList();
        }
               

    }
}
