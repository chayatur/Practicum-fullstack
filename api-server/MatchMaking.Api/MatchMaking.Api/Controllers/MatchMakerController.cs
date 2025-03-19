using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MatchMaking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchMakerController : ControllerBase
    {
        // GET: api/<MatchMakerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MatchMakerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MatchMakerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MatchMakerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MatchMakerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
