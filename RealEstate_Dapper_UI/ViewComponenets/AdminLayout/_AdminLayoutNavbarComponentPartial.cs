using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponenets.AdminLayout
{
    public class _AdminLayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
