using la_mia_pizzeria_crude_mvc.Models;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

            List<Pizza> pizzas;

            if (name is null)
            {
                pizzas = _ctx.Pizzas?.Include("Category").Include("Ingredients").ToList()!;
            }
            else
            {

                pizzas = _ctx.Pizzas?.Where(p => p.Name.ToLower().Contains(name.ToLower())).Include("Category").Include("Ingredients").ToList()!;
            }
            
            return Ok(pizzas);

        }
        [HttpGet("{id}")]
        public IActionResult Show(int id)
        {
            //cercare la pizza e passarla alla vista
            Pizza pizza = _ctx.Pizzas?.Include("Category").Include("Ingredients").FirstOrDefault(p => p.Id == id)!;
            return Ok(pizza);
        }
        
    }
}
