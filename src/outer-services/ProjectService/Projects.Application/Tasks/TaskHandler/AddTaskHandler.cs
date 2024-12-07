using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Projects.Application.Tasks.TaskRequest;
using Projects.DataPersistance.DatabaseContext.ProjectDbContext;
using TaskEntity = Projects.Core.Entities.Task;

namespace Projects.Application.Tasks.TaskHandler
{
    public class AddTaskHandler : IRequestHandler<AddTaskRequest, long>
    {
        private readonly ProjectDbContext _context;
        private readonly IMapper _mapper;
        public AddTaskHandler(ProjectDbContext context , IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<long> Handle(AddTaskRequest request, CancellationToken cancellationToken)
        {
            var a= request.ProjectId;
            var project = _context.Projects.Where(x => x.Id == request.ProjectId).FirstOrDefault();
            if (project == null) 
            {
                throw new ArgumentException();
            }

            var task =_mapper.Map<TaskEntity>(request);
            task.Number = $"{project.Tag}{project.TaskList.Count + 1}";

            task.ParentTask = _context.Tasks
                .Where(x => x.ParentTaskId == request.ParrentTaskId)
                .FirstOrDefault();

            task.Project = project;

            task.CreateDate = DateTime.UtcNow;

            task.InspectorsId = project.CustomersId;

            _context.Tasks.Add(task);
            _context.SaveChanges();

            return task.Id;
        }
    }
}
