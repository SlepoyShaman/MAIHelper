using maihelper.Data;
using Microsoft.AspNetCore.Mvc;
using maihelper.Models.ExchangeModels;
using maihelper.Models.DataModels;
using maihelper.Models.Interfaces;

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

        [HttpPost("AddNewWork")]
        public IActionResult AddNewWork([FromBody]AdminGetModel model)
        {
            bool NewWorkStatus = true;
            IEnumerable<Work> prevWorks = _repository.GetAll<Work>().Where(w => w.WorkType == model.WorkType
                                                      && w.IsOnPage).ToArray();
                                                     
            foreach(var w in prevWorks)
            {
                if(w.SubjectId == model.SubjectId)
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
    }
}
