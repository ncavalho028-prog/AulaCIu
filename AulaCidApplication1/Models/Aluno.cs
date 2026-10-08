using Microsoft.AspNetCore.Mvc;

namespace AulaCidApplication1.Models
{
    public class Aluno : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
