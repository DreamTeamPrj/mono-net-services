using Microsoft.AspNetCore.Mvc;
using Projects.Application.Tasks.TaskRequest;
using Projects.DataPersistance.DatabaseContext.ProjectDbContext;

namespace Projects.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskControllerApi : BaseControllerApi
    {
        private readonly ProjectDbContext _context;

        public TaskControllerApi(ProjectDbContext context) 
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> AddTask(AddTaskRequest request)
        {
            var responce = await Mediator.Send(request);
            return Ok(responce);
        }
        //[HttpPost]
        //public async Task<IActionResult> da()
        //{
        //    _context.Projects.Add(new Core.Entities.Project());
        //    return Ok();
        //}
    }
}
