using Microsoft.AspNetCore.Mvc;

namespace AulaCidApplication1.Models
{
    public class Professor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
