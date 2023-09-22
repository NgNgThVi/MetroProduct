using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasesController : ControllerBase
    {
        // GET: api/<BasesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BasesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BasesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BasesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BasesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
