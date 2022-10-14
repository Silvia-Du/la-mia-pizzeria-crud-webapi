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
        public IActionResult Get()
        {
            List<Pizza> pizzas = _ctx.Pizzas?.ToList()!;

            if (pizzas is null)
            {
                string message = "Non è stato possibile estrarre i dati dal db, la lista è null";
                UnprocessableEntity(message);
            }

            return Ok(pizzas);
       
        }
    }
}
