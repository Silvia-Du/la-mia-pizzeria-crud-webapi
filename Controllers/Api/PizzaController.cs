using la_mia_pizzeria_crude_mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        readonly PizzeriaContext _ctx = new();

        [HttpGet]
        public IActionResult Get()
        {
            List<Pizza> pizzas = _ctx.Pizzas?.ToList()!;           
            return Ok(pizzas);
        }
    }
}
