using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2302C2FirstAPI.Controllers
{
    [Route("api/[controller]")]//api/Test
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet("{num}")]
        public ActionResult Get(int num) {
            int number = num;

            if(number <= 400)
            {

            return Ok("Valid Number");
            }
            else
            {
                return BadRequest("Sorry invalid number");
            }
        }
    }
}
