using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectManagement.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private List<Project> _projectList;

        private ILoggerManager _logger;
        public ProjectsController(ILoggerManager logger)
        {
            _logger = logger;

            _projectList = new List<Project>
            {
                new Project{Id=Guid.NewGuid(), Name="Project 1"},
                new Project{Id=Guid.NewGuid(), Name="Project 2"},
                new Project{Id=Guid.NewGuid(), Name="Project 3"}
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                /*
                // aşağıdaki işlemler uygulama çalışırken hata vermesi ve bu hatanın ekranda görülmesi için kullanılabilir
                int a = 10;
                int b = 0;
                int c = a / b;
                */
                _logger.LogInfo("Projects.Get() has been run. ");
                return Ok(_projectList);
            }
            catch (Exception ex)
            {
                _logger.LogError("Projects.Get() has been crashed : " + ex.Message);
                throw;
            }
        }
    }
}
