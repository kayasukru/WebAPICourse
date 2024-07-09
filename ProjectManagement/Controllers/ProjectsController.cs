using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace ProjectManagement.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private IServiceManager _service;
        public ProjectsController(ILoggerManager logger, IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = _service.ProjectService.GetAllProjects(false);
            return Ok(list);
        }
    }
}
