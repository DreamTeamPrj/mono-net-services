using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Projects.Application.Tasks.TaskRequest;
using Projects.DataPersistance.DatabaseContext.ProjectDbContext;
using TaskEntity = Projects.Core.Entities.Task;

namespace Projects.Application.Tasks.TaskHandler
{
    public class AddTaskCommandHanlder : IRequestHandler<AddTaskCommand, long>
    {
        private readonly ProjectDbContext _context;
        private readonly IMapper _mapper;
        public AddTaskCommandHanlder(ProjectDbContext context , IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<long> Handle(AddTaskCommand request, CancellationToken cancellationToken)
        {
            var project = await _context.Projects.Where(x => x.Id == request.ProjectId).FirstOrDefaultAsync();

            if (project == null) 
            {
                throw new ArgumentException();
            }

            var task = _mapper.Map<TaskEntity>(request);

            task.Number = $"{project.Tag}{project.TaskList.Count + 1}";

            task.ParentTask = await _context.Tasks
                .Where(x => x.ParentTaskId == request.ParrentTaskId)
                .FirstOrDefaultAsync();

            task.ProjectId = project.Id;
            task.StatusId = request.Status ?? project.DefaultStatus;
            task.CreateDate = DateTime.UtcNow;

            task.InspectorsId = project.CustomersId;

            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();

            return task.Id;
        }
    }
}
