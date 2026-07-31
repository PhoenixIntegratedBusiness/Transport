using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Transport.web.Models;

namespace Transport.web.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }

   
    }
}
