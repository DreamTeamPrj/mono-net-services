
using MediatR;
using Projects.Core.Entities;
using Projects.Core.Enums;

namespace Projects.Application.Tasks.TaskRequest
{
    public class AddTaskRequest : IRequest<long>
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string DescriptionLink { get; set; }
        public int Status { get; set; }
        public Priority Priority { get; set; } = Priority.Medium;
        public int Creator { get; set; }
        public int? WorkerId { get; set; }
        public long? ParrentTaskId { get; set; }
        public string? TimeSpan { get; set; }
        public int? ReleaseId { get; set; }
    }
}
