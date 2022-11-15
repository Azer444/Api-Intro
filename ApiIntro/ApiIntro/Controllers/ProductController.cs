using Microsoft.AspNetCore.Mvc;

namespace ApiIntro.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetById(int id)
        {
            string name = "Azer" + id;
            return Ok(name);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<string> names = new List<string>()
            {
                "Azer","Maqa","Huseyn"
            };
            return Ok(names);
        }
    }
}
