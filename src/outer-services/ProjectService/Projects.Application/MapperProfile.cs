using AutoMapper;
using Projects.Application.Tasks.TaskRequest;
using TaskEntity = Projects.Core.Entities.Task;


namespace Projects.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddTaskCommand, TaskEntity>();
        }
    }

}
