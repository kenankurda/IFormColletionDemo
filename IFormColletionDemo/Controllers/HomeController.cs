using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IFormColletionDemo.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection collection)
        {
            ViewBag.FirstName = (collection["txtFirstName"]).ToString();
            ViewBag.LastName = (collection["txtLastName"]).ToString();
            ViewBag.Age = (collection["txtAge"]).ToString();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
