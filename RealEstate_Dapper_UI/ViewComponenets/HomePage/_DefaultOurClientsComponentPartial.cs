﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponenets.HomePage
{
    public class _DefaultOurClientsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}