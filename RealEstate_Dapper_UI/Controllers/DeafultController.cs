using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class DeafultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
