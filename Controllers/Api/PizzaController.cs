using la_mia_pizzeria_crude_mvc.Models;
using la_mia_pizzeria_static.Models;
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
        public IActionResult Get(string? name)
        {
            IQueryable<Pizza> pizzas;

            if (name is null)
            {
                pizzas = _ctx.Pizzas!;
            }
            else
            {
                pizzas = _ctx.Pizzas?.Where(p => p.Name.ToLower().Contains(name.ToLower()))!;
            }
            
            return Ok(pizzas.ToList<Pizza>());


        }
    }
}
