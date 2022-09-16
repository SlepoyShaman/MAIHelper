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
        private readonly IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        private readonly int LabsOnPageCount = 2;
        private readonly int NotesOnPageCount = 2;
        private readonly int TicketsOnPageCount = 7;

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

        private IEnumerable<T> GetLastElements<T>(int quantity) where T : class, IWithId
        {
            return _repository.GetAll<T>().OrderByDescending(x => x.Id).Take(quantity);
        }


    }
}
