using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.UILayoutComponents
{
    public class _UILayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
