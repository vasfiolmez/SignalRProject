﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.DefaultComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {return View();}
    }
}
