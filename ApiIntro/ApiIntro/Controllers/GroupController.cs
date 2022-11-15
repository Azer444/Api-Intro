using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiIntro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            List<Group> groups = new List<Group>();
            Group group1 = new()
            {
                Id= 1,
                Name = "P130",
                Capacity= 16
            };
            Group group2 = new()
            {
                Id = 1,
                Name = "EL214",
                Capacity = 18
            };
            Group group3 = new()
            {
                Id = 1,
                Name = "P126",
                Capacity = 22
            };

            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);

            return Ok(groups);

        }
    }
}
