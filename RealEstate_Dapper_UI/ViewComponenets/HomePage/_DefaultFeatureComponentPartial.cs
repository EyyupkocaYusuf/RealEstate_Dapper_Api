using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponenets.HomePage
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
