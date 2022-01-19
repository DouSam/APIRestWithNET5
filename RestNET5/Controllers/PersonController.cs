using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestNET5.Business;
using RestNET5.Models;

namespace RestNET5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private readonly IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personService)
        {
            _logger = logger;
            _personBusiness = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Person person = _personBusiness.FindByID(id);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {

            if (person == null)
                return BadRequest();

            return Ok(_personBusiness.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {

            if (person == null)
                return BadRequest();

            return Ok(_personBusiness.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
