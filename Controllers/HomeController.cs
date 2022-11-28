using maihelper.Data;
using Microsoft.AspNetCore.Mvc;
using maihelper.Models.ExchangeModels;
using maihelper.Models.DataModels;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> ViewHome()
        {
            var result = await _repository.GetAll<Work>().Where(w => w.IsOnPage).Select(w => new HomePageRetModel() { 
                Title = w.Subject.Title,
                SubjectId = w.SubjectId,
                WorkType = w.WorkType
            }).ToArrayAsync();
            return Ok(result);
        }
    }
}
