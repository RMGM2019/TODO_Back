using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace TODO.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class TestController:ControllerBase{
        [HttpGet("")]
        public IActionResult TestMethod(){
            Console.WriteLine("Entro a test");
            return new OkObjectResult(new {msg="Hola"});
        }
    }
}