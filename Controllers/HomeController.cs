using la_mia_pizzeria_crude_mvc.Models;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;

namespace la_mia_pizzeria_crude_mvc.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {           
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult BuyOnline()
        {
            return View();
        }

    }
}