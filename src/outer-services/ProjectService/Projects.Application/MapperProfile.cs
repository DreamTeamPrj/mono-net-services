using AutoMapper;
using Projects.Application.Tasks.TaskRequest;
using TaskEntity = Projects.Core.Entities.Task;


namespace Projects.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddTaskRequest, TaskEntity>()
                .ForMember(dest => dest.Number, opt => opt.Ignore()) 
                .ForMember(dest => dest.DescriptionLink, opt => opt.MapFrom(src => src.DescriptionLink))
                .ForMember(dest => dest.ParentTask, opt => opt.Ignore()) 
                .ForMember(dest => dest.Project, opt => opt.Ignore());
        }
    }

}
