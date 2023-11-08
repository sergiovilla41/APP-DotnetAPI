using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todo.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController() { }
        [HttpGet]
        public async Task<IActionResult> GetHelloWorld() {
            return Ok("Hola Mundito");
        }
        // GET: api/<UserController>
       
        
    }
}
