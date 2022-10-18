using la_mia_pizzeria_crude_mvc.Models;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        readonly PizzeriaContext _ctx = new();

        [HttpPost]

        public IActionResult Send(Message message)
        {

            return Ok();

        }
        
    }
}
