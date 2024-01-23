using Microsoft.AspNetCore.Mvc;

namespace suave.Controllers
{
    [Route("[controller]")]
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }       
    }
}