using maihelper.Data;
using maihelper.Models.DataModels;
using maihelper.Models.ExchangeModels;
using Microsoft.AspNetCore.Mvc;

namespace maihelper.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly List<Work> _HomePageWorkList;

        public AdminController(IRepository repository)
        {
            _repository = repository;
            _HomePageWorkList = _repository.GetAll<Work>().Where(w => w.IsOnPage).ToList();
        }

        [HttpPost("AddNewWork")]
        public async Task<IActionResult> AddNewWork([FromBody] NewWorkGetModel model)
        {
            try 
            { 
                var subject = await _repository.GetByIdAsync<Subject>(model.SubjectId);
                bool NewWorkStatus = true;

                var prevWorks = _HomePageWorkList.Where(w => w.WorkType == model.WorkType);

                if (prevWorks.Select(w => w.SubjectId).Contains(model.SubjectId))
                    NewWorkStatus = false;
                else
                {
                    NewWorkStatus = true;
                    Work oldWork = prevWorks.First();
                    await _repository.UpdateWorkPageFlagAsync(oldWork);
                    _HomePageWorkList.Remove(oldWork);
                }

                Work work = new()
                {
                    Title = model.Title,
                    WorkType = model.WorkType,
                    Subject = subject,
                    IsOnPage = NewWorkStatus
                };

                await _repository.AddNewItemAsync<Work>(work);
                _HomePageWorkList.Add(work);
                return Ok();

            }
            catch 
            { 
                return BadRequest(new { Error = $"Subject with Id: {model.SubjectId} are not exist" }); 
            }
        }

        [HttpPost("RemoveWork")]
        public async Task<IActionResult> Remove([FromBody] RemoveWorkGetModel model)
        {
            try
            {
                var work = await _repository.RemoveByIDAsync<Work>(model.Id);
                if (work.IsOnPage)
                {
                    var alreadyOnHomePage = _HomePageWorkList.Where(w => w.WorkType == work.WorkType)
                                                            .Select(w => w.SubjectId);

                    Work? NewWorkOnHomePage = _repository.GetAll<Work>()
                        .Where(w => w.WorkType == work.WorkType && !alreadyOnHomePage.Contains(w.SubjectId))
                        .FirstOrDefault();

                    if (NewWorkOnHomePage != null) await _repository.UpdateWorkPageFlagAsync(NewWorkOnHomePage);
                }
                return Ok();
            }
            catch
            {
                return BadRequest(new { Error = $"The Work with id:{model.Id} do not exist" });
            }
        }
    }
}
