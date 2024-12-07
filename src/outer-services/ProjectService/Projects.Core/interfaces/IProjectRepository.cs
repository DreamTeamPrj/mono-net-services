
using Projects.Core.Entities;

namespace Projects.Core.interfaces
{
    public interface IProjectRepository
    {
        public Task<Project> GetProject(int Id);
        public Task<int> AddProject(Project project);
    }
}
