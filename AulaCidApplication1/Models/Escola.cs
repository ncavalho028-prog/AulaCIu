using Microsoft.AspNetCore.Mvc;

namespace AulaCidApplication1.Models
{
    public class Escola : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
