using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Presentation.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ProjectsController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllProjects()
        {
            var projects = _service.ProjectService.GetAllProjects(false);
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public IActionResult GetOneProjectById(Guid id)
        {
            //throw new Exception("Exception ...");
            var project = _service.ProjectService.GetOneProjectById(id, false);
            return Ok(project);
        }
    }
}
