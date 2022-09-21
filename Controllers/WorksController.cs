using maihelper.Data;
using maihelper.Models.DataModels;
using maihelper.Models.ExchangeModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetData([FromBody]WorksGetModel model)
        {
            var result = _repository.GetAll<Work>().Where(w => w.WorkType == model.WorkType && 
                                                               w.SubjectId == model.SubjectId)
                                      .Skip(ItemsOnPageCount * (model.PageNumber - 1))
                                      .Take(ItemsOnPageCount).Select(w => new WorksRetModel()
                                      {
                                          Title = w.Title
                                      });
            return Ok(result);
        }
    }
}
