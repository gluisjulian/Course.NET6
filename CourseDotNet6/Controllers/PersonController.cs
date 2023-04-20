using Microsoft.AspNetCore.Mvc;

namespace CourseDotNet6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<PersonController> Get()
        {
            
        }
    }
}