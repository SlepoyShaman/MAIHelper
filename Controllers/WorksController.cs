using maihelper.Data;
using maihelper.Models.DataModels;
using maihelper.Models.ExchangeModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace maihelper.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WorksController : ControllerBase
    {
        private readonly IRepository _repository;
        public WorksController(IRepository repository)
        {
            _repository = repository;
        }

        private readonly int ItemsOnPageCount = 10;

        [HttpPost]
        public async Task<IActionResult> GetData([FromBody]WorksGetModel model)
        {
            if (model.PageNumber <= 0) model.PageNumber = 1;
            var result = await _repository.GetAll<Work>().Where(w => w.WorkType == model.WorkType && 
                                                               w.SubjectId == model.SubjectId)
                                      .Skip(ItemsOnPageCount * (model.PageNumber - 1))
                                      .Take(ItemsOnPageCount).Select(w => new WorksRetModel()
                                      {
                                          Id = w.Id,
                                          Title = w.Title
                                      }).ToArrayAsync();

            return result.Any() ? Ok(result) : BadRequest(new { Error = "Работы не найдены"} );
        }
    }
}
