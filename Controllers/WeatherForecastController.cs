using Microsoft.AspNetCore.Mvc;
using maihelper.Data;

namespace maihelper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private ApplicationDbContext _context;

        public WeatherForecastController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Names")]
        public IActionResult GetStrings(string param, string los)
        {
            return BadRequest("ghjgjg");
        }

        //[HttpPost]
        //public IActionResult Hello([FromBody]WeatherGetModel model)
        //{
        //    return Ok(model.Id + 12);
        //}
    }
}