using Microsoft.AspNetCore.Mvc;
using Projects.Application.Tasks.TaskRequest;

namespace Projects.Api.Controllers
{
    public class TaskControllerApi : BaseControllerApi
    {

        [HttpPost]
        public Task<long> AddTask(AddTaskRequest request)
        {
            return Mediator.Send(request);
        }
    }
}
