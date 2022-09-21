using maihelper.Data;
using maihelper.Models.DataModels;
using maihelper.Models.ExchangeModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace maihelper.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IRepository _repository;
        public AdminController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("AddNewWork")]
        public IActionResult AddNewWork([FromBody] NewWorkGetModel model)
        {
            bool NewWorkStatus = true;
            IEnumerable<Work> prevWorks = _repository.GetAll<Work>().Where(w => w.WorkType == model.WorkType
                                                      && w.IsOnPage).ToArray();

            foreach (var w in prevWorks)
            {
                if (w.SubjectId == model.SubjectId)
                    NewWorkStatus = false;
                else
                {
                    var oldWork = prevWorks.FirstOrDefault();
                    oldWork.IsOnPage = false;
                    _repository.Update();
                }
            }

            Work work = new Work()
            {
                Title = model.Title,
                WorkType = model.WorkType,
                Subject = _repository.GetById<Subject>(model.SubjectId)
            };

            work.IsOnPage = NewWorkStatus;

            _repository.AddNewItem<Work>(work);
            return Ok();
        }

        [HttpPost("RemoveWork")]
        public IActionResult Remove([FromBody] RemoveWorkGetModel model)
        {
            var work = _repository.GetById<Work>(model.Id);
            if (work == null)
            {
                return BadRequest($"The Work with id:{model.Id} do not exist");
            }
            else if (work.IsOnPage)
            {
                var NewPageWork = _repository.GetAll<Work>().Where(w => w.WorkType == work.WorkType &&
                                                       w.IsOnPage == false &&
                                                       w.SubjectId == work.SubjectId).FirstOrDefault();
                if(NewPageWork != null)
                {
                    NewPageWork.IsOnPage = true;
                    _repository.Update();
                }   
            }
            _repository.RemoveByID<Work>(model.Id);
            return Ok();
        }
    }
}
