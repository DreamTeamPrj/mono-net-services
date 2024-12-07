using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Projects.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseControllerApi : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
