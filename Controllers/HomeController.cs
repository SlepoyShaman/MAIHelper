using maihelper.Data;
using maihelper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public IEnumerable<LaboratoryWork> ViewIndexPage()
               => _repository.GetAll<LaboratoryWork>();

    }
}
