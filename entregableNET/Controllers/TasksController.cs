using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace entregableNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public ActionResult GETall()
        {
            return Ok();
        }

        [HttpPost]  
        public ActionResult POST(Task task)
        {
            return Ok(task);
        }

        [HttpPut]
        public ActionResult PUT(Task task)
        {
            return Ok(task);
        }

        [HttpDelete]
        public ActionResult DELETE(Task task)
        {
            return Ok(task);

        }
    }
}
