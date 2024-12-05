using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projects.DataPersistance.DatabaseContext.ProjectDbContext;

namespace Projects.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ProjectDbContext _context;

        public ValuesController(ProjectDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<string> GetAsync()
        {
            _ = _context.Projects;
            return "abc";
        } 
    }
}
