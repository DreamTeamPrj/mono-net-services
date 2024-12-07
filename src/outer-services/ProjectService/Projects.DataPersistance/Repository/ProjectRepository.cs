using Microsoft.EntityFrameworkCore;
using Projects.Core.Entities;
using Projects.Core.interfaces;
using Projects.DataPersistance.DatabaseContext.ProjectDbContext;

namespace Projects.DataPersistance.Repository
{
    internal class ProjectRepository : IProjectRepository
    {
        private readonly ProjectDbContext _context;
        public ProjectRepository(ProjectDbContext context) 
        {
            _context = context;
        }
        public async Task<int> AddProject(Project project)
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();

            return _context.Projects.Last().Id;
        }

        public async Task<Project> GetProject(int Id)
        {
            return await _context.Projects
                .Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
    }
}
