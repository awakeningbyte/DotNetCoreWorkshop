using FizzBuzz.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IFizzBuzzParser parser;

        public ValuesController(IFizzBuzzParser parser)
        {
            this.parser = parser;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return parser.Parse(id);
        }
    }
}
