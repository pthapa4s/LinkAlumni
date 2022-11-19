using Microsoft.AspNetCore.Mvc;

namespace LinkAlumni.Controllers
{
    public class PrivateController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
     
    }
}
