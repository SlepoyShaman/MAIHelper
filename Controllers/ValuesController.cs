using maihelper.Data;
using maihelper.Models.DataModels;
using maihelper.Models.ExchangeModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace maihelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRepository _repository;
        public ValuesController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public IActionResult ViewHome()
        {
            var result = _repository.GetAll<Work>().Where(q => q.IsOnPage).Select(q => new HomePageRetModel
            {
                SubjectId = q.SubjectId,
                Title = q.Subject.Title,
                WorkType = q.WorkType
            });
           
            return Ok(result);
        }

        [HttpPost("AddNewWork")]
        public IActionResult NewWork(Work work)
        {
            var prevWork = _repository.GetAll<Work>().Where(q => q.WorkType == work.WorkType).FirstOrDefault(q => q.IsOnPage);
            prevWork.IsOnPage = false;

            //TODO::Update this prevWork

            work.IsOnPage = true;

            //TODO::Add new item in context - done
            return Ok();
        }
        [HttpPost("GetWorks")]
        public IActionResult GetWorks([FromBody] HomePageGetModel model)
        {
            var result = _repository.GetAll<Work>().Where(w => w.WorkType == model.WorkType);
            return Ok(result);
        }
    }
}
