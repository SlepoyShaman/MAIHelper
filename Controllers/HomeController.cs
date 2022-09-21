using maihelper.Data;
using Microsoft.AspNetCore.Mvc;
using maihelper.Models.ExchangeModels;
using maihelper.Models.DataModels;

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
